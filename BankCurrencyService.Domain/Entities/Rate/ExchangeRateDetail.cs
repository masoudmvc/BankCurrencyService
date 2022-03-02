using BankCurrencyService.Domain.Entities.Currency;

namespace BankCurrencyService.Domain.Entities.Rate
{
    public class ExchangeRateDetail : EntityBase<Guid>
    {
        public decimal Rate { get; set; }
        public string? Currency { get; set; }

        public Guid ExchangeRateKey { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
}
