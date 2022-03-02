using BankCurrencyService.Domain.Entities.Currency;

namespace BankCurrencyService.Domain.Entities.Rate
{
    public class ExchangeRate : EntityBase<Guid>
    {
        public DateTime ResourceDeclaredUpdateDateTime { get; set; }

        public Guid? ExchangeRateResourceKey { get; set; }
        public virtual ExchangeRateResource ExchangeRateResource { get; set; }

        public virtual ICollection<ExchangeRateDetail> ExchangeRateDetails { get; set; }
    }
}
