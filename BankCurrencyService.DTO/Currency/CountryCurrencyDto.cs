namespace BankCurrencyService.DTO.Currency
{
    public class CountryCurrencyDto
    {
        public int Key { get; set; }
        public string? CountryName { get; set; }
        public string? AcronymAbb { get; set; }
        public int RowOrder { get; set; }
        public bool IsAvailable { get; set; }
    }
}
