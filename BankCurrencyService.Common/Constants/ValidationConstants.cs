namespace BankCurrencyService.Common.Constants
{
    public static class ValidationConstants
    {
        public const int FirstNameMaxLength = 100;
        public const int LastNameMaxLength = 200;
        public const int FullNameMaxLength = FirstNameMaxLength + LastNameMaxLength + 1;
        public const int UserName = 100;
        public const int CountryName = 32;
        public const int AcronymAbb = 16;
        public const int Currency = 16;
        public const string EcbUri = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?4610f020d7463a0cd43d6828905faf2f";
    }
}
