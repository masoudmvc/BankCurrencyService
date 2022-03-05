using BankCurrencyService.Data;
using BankCurrencyService.Domain.Entities.Currency;
using BankCurrencyService.DTO.Currency;
using BankCurrencyService.DTO.ServiceOutputBase;
using BankCurrencyService.Service.Base;
using Microsoft.EntityFrameworkCore;

namespace BankCurrencyService.Service.Currency
{
    public class CurrencyService : ServiceBase, ICurrencyService
    {
        private readonly BankCurrencyDbContext _db;

        public CurrencyService(BankCurrencyDbContext db,
            IServiceEssentials<CurrencyService> _serviceEssentials) : base(_serviceEssentials)
        {
            _db = db;
        }

        public async Task<ListQueryResult<CountryCurrencyDto>> GetAllCurrencies(CancellationToken cancellationToken)
        {
            var list = await _db.Set<CountryCurrency>()
                .OrderBy(x => x.CountryName).ToListAsync(cancellationToken);

            if (list == null) throw new Exception("No country currency has been added yet!");

            var result = new ListQueryResult<CountryCurrencyDto>
            {
                Entities = _essentials.Mapper.Map<List<CountryCurrencyDto>>(list)
            };

            return result;
        }
    }
}
