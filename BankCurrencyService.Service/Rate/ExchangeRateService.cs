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
    }
}
