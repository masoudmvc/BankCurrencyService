namespace BankCurrencyService.DTO.Rate
{
    public class ExchangeRateDetailDto
    {
        public Guid Key { get; set; }
        public decimal Rate { get; set; }
        public string? Currency { get; set; }
    }
}
