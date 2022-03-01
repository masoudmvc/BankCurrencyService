namespace BankCurrencyService.Common.Constants
{
    public static class ValidationConstants
    {
        public const int FirstNameMaxLength = 100;
        public const int LastNameMaxLength = 200;
        public const int FullNameMaxLength = FirstNameMaxLength + LastNameMaxLength + 1;
        public const int UserName = 100;
    }
}
