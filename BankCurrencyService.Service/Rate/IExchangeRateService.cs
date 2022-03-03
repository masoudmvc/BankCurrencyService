using BankCurrencyService.DTO.Rate;
using BankCurrencyService.DTO.ServiceOutputBase;

namespace BankCurrencyService.Service.Rate
{
    public interface IExchangeRateService
    {
        Task FetchOnlineExchangeRateECB(CancellationToken cancellationToken);
        Task<SingleQueryResult<ExchangeRateDto>> GetAvailableCurrencies(CancellationToken cancellationToken);
    }
}
