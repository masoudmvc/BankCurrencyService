namespace BankCurrencyService.Domain
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        string? Creator { get; set; }
        string? CreatorUserName { get; set; }
        Guid? CreatorKey { get; set; }
        DateTime? LastUpdatedDate { get; set; }
        string? LastUpdater { get; set; }
        string? LastUpdaterUserName { get; set; }
        Guid? LastUpdaterKey { get; set; }
    }
    public interface IEntity<TKey> : IEntity
    {
        TKey Key { get; set; }
        
    }
}
