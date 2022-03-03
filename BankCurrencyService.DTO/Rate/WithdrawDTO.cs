namespace BankCurrencyService.DTO.Rate
{
    public class WithdrawDTO
    {
        public decimal Amount { get; set; }
        public string CurrencyOfTheCountryWhereYouAre { get; set; }
        public string CurrencyOfYourCountry { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal MoneyWithdrawnFromYourAccount { get; set; }
    }
}
