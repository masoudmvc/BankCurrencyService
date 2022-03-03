using BankCurrencyService.DTO.Currency;
using BankCurrencyService.DTO.ServiceOutputBase;

namespace BankCurrencyService.Service.Currency
{
    public interface ICurrencyService
    {
        Task<ListQueryResult<CountryCurrencyDto>> GetAllCurrencies(CancellationToken cancellationToken);
    }
}
