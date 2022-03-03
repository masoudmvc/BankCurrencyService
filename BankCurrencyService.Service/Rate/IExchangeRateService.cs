using BankCurrencyService.DTO.Rate;
using BankCurrencyService.DTO.ServiceOutputBase;

namespace BankCurrencyService.Service.Rate
{
    public interface IExchangeRateService
    {
        Task FetchOnlineExchangeRateECB(CancellationToken cancellationToken);
        Task<SingleQueryResult<ExchangeRateDto>> GetAvailableCurrencies(CancellationToken cancellationToken);
        Task<SingleQueryResult<ExchangeRateDetailDto>> GetCurrencyRate(string acronym, CancellationToken cancellationToken);
        Task<ConvertDto> ConvertFromBaseRate(ConvertCommand command, CancellationToken cancellationToken);
        Task<WithdrawDTO> WithdrawMoney(WithdrawCommand command, CancellationToken cancellationToken);
    }
}
