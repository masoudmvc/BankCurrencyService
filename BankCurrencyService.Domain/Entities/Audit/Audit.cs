namespace BankCurrencyService.Domain.Entities.Audit
{
    public class Audit : EntityBase<Guid>
    {
        public string? EntityType { get; set; }
        public string? EntityId { get; set; }
        public string? Value { get; set; }
        public AuditAction Action { get; set; }
    }

    public enum AuditAction
    {
        Create = 1,
        Update = 2,
        Delete = 3
    }
}
