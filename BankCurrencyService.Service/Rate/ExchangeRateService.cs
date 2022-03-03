using BankCurrencyService.Common.Constants;
using BankCurrencyService.Common.XmlHelper;
using BankCurrencyService.Data;
using BankCurrencyService.Domain.Entities.Rate;
using BankCurrencyService.DTO.Rate;
using BankCurrencyService.DTO.ServiceOutputBase;
using BankCurrencyService.Service.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;

namespace BankCurrencyService.Service.Rate
{
    public class ExchangeRateService : ServiceBase, IExchangeRateService
    {
        private readonly BankCurrencyDbContext _db;
        public ExchangeRateService(BankCurrencyDbContext db,
            IServiceEssentials<ExchangeRateService> _serviceEssentials) : base(_serviceEssentials)
        {
            _db = db;
        }

        public async Task FetchOnlineExchangeRateECB(CancellationToken cancellationToken)
        {
            try
            {
                using var client = new HttpClient();
                using var responseMessage = await client
                    .GetAsync(ValidationConstants.EcbUri, cancellationToken);

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var responseString = await responseMessage.Content.ReadAsStringAsync(cancellationToken);

                    if (!string.IsNullOrWhiteSpace(responseString))
                    {
                        var response = XmlHelper.FromXml<Envelope>(responseString);

                        if (response.Success)
                            await AddEcbExchangeRates(response.Entity, cancellationToken);
                    }
                }

            }
            catch (Exception e)
            {
                _essentials.Logger.LogInformation("Error while getting exchange rates from ECB!");
                throw;
            }
        }

        public async Task<SingleQueryResult<ExchangeRateDto>> GetAvailableCurrencies(CancellationToken cancellationToken)
        {
            var availableList = await _db.Set<ExchangeRate>()
                .Include(x => x.ExchangeRateDetails)
                .Include(x => x.ExchangeRateResource)
                .OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync(cancellationToken);

            if (availableList == null) throw new Exception("No exchange rate has been fetched yet!");

            var result = new SingleQueryResult<ExchangeRateDto>
            {
                Entity = _essentials.Mapper.Map<ExchangeRateDto>(availableList)
            };

            return result;
        }

        public async Task<SingleQueryResult<ExchangeRateDetailDto>> GetCurrencyRate(string acronym, CancellationToken cancellationToken)
        {
            var availableCurrency = await _db.Set<ExchangeRateDetail>()
                .OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync(x => x.Currency == acronym, cancellationToken);

            if (availableCurrency == null) throw new Exception($"{acronym} does not exist in available currencies");

            var result = new SingleQueryResult<ExchangeRateDetailDto>
            {
                Entity = _essentials.Mapper.Map<ExchangeRateDetailDto>(availableCurrency)
            };

            return result;
        }

        public async Task<ConvertDto> ConvertFromBaseRate(ConvertCommand command, CancellationToken cancellationToken)
        {
            var sourceCurrencyExchangeRate = (command.FromCurrency == "EUR") ? 1 
                : (await GetCurrencyRate(command.FromCurrency, cancellationToken)).Entity?.Rate;

            var destCurrencyExchangeRate = (command.ToCurrency == "EUR") ? 1
                : (await GetCurrencyRate(command.ToCurrency, cancellationToken)).Entity?.Rate;

            if (sourceCurrencyExchangeRate == null) 
                throw new Exception($"Can't fetch {command.FromCurrency} exchange rate");

            if (destCurrencyExchangeRate == null) 
                throw new Exception($"Can't fetch {command.ToCurrency} exchange rate");

            return CalculateAndConvert(command, sourceCurrencyExchangeRate.Value, destCurrencyExchangeRate.Value);
        }

        public async Task<WithdrawDTO> WithdrawMoney(WithdrawCommand command, CancellationToken cancellationToken)
        {
            var param = new ConvertCommand
            {
                Amount = command.Amount,
                FromCurrency = command.CurrencyOfTheCountryWhereYouAre,
                ToCurrency = command.CurrencyOfYourCountry
            };

            var temp = await ConvertFromBaseRate(param, cancellationToken);

            return new WithdrawDTO
            {
                MoneyWithdrawnFromYourAccount = temp.ConvertedAmount,
                Amount = temp.Amount,
                ExchangeRate = temp.ExchangeRate,
                CurrencyOfTheCountryWhereYouAre = command.CurrencyOfTheCountryWhereYouAre,
                CurrencyOfYourCountry = command.CurrencyOfYourCountry
            };
        }

        private async Task AddEcbExchangeRates(Envelope? param, CancellationToken cancellationToken)
        {
            if (param?.Cube?.Cube1 != null)
            {
                var declaredTime = param.Cube.Cube1.time;
                var list = param.Cube.Cube1.Cube;

                if (list != null && list.Any())
                {
                    var entitiesDetailToAdd = new List<ExchangeRateDetail>();
                    foreach (var x in list)
                    {
                        entitiesDetailToAdd.Add(new ExchangeRateDetail
                        {
                            Rate = x.rate,
                            Currency = x.currency,
                        });
                    }

                    var entity = new ExchangeRate
                    {
                        ResourceDeclaredUpdateDateTime = declaredTime,
                        ExchangeRateResourceKey = Guid.Parse(ValidationConstants.EcbKey),
                        ExchangeRateDetails = entitiesDetailToAdd
                    };

                    _db.Add(entity);
                    await _db.SaveChangesAsync(cancellationToken);
                }
            }
        }

        private ConvertDto CalculateAndConvert(
            ConvertCommand command, decimal sourceCurrencyExchangeRate, decimal destCurrencyExchangeRate)
        {
            var result = new ConvertDto
            {
                Amount = command.Amount,
                FromCurrency = command.FromCurrency,
                ToCurrency = command.ToCurrency,
                ExchangeRate = destCurrencyExchangeRate / sourceCurrencyExchangeRate,
                ConvertedAmount = (destCurrencyExchangeRate / sourceCurrencyExchangeRate) * command.Amount
            };

            //result.ExchangeRate
            //result.ConvertedAmount

            //TODO: should calculate "Commission"
            return result;
        }
    }
}
