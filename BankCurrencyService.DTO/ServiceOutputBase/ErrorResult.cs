namespace BankCurrencyService.DTO.ServiceOutputBase
{
    public class ErrorResult : ResultBase
    {
        /// <summary>
        /// Gets always false. Cannot be set.
        /// </summary>
        public new bool Success => false;
    }
}
