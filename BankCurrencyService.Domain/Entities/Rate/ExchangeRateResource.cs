namespace BankCurrencyService.Domain.Entities.Rate
{
    public class ExchangeRateResource : EntityBase<Guid>
    {
        public string? ResourceName { get; set; }
        public string? ApiKey { get; set; }
        public string? ResourceUri { get; set; }

        public virtual ICollection<ExchangeRate> ExchangeRates { get; set; }
    }
}
