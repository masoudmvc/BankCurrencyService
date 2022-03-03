namespace BankCurrencyService.DTO.Rate
{
    public class ConvertCommand
    {
        public decimal Amount { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
    }
}
