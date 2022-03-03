namespace BankCurrencyService.DTO.Rate
{
    public class ExchangeRateDto
    {
        public Guid Key { get; set; }
        public DateTime ResourceDeclaredUpdateDateTime { get; set; }
        public string? ExchangeRateResourceName { get; set; }
        public List<ExchangeRateDetailDto> ExchangeRateDetails { get; set; } = new List<ExchangeRateDetailDto>();
    }
}
