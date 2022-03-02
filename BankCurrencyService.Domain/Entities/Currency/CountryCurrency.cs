namespace BankCurrencyService.Domain.Entities.Currency
{
    public class CountryCurrency : EntityBase<int>
    {
        public string? CountryName { get; set; }
        public string? AcronymAbb { get; set; }
        public int RowOrder { get; set; }
        public bool IsAvailable { get; set; }
    }
}
