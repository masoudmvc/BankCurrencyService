namespace BankCurrencyService.DTO.ServiceOutputBase
{
    public class ListQueryResult<TEntity> : ResultBase
    {
        public ICollection<TEntity>? Entities { get; set; }

    }
}
