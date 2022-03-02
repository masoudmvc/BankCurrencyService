namespace BankCurrencyService.DTO.ServiceOutputBase
{
    /// <summary>
    /// Base class for returned DTOs
    /// </summary>

    public abstract class ResultBase
    {
        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage) && (Errors == null || Errors.Count == 0);
        public string? ErrorMessage { get; set; }
        public IDictionary<string, object>? Errors { get; set; }
    }
}
