namespace BankCurrencyService.DTO.Rate
{
    public class WithdrawCommand
    {
        public decimal Amount { get; set; }
        public string CurrencyOfTheCountryWhereYouAre { get; set; }
        public string CurrencyOfYourCountry { get; set; }
    }
}
