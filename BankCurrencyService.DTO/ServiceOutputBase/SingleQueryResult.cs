namespace BankCurrencyService.DTO.ServiceOutputBase
{
    public class SingleQueryResult<TEntity> : ResultBase
    {
        public TEntity? Entity { get; set; }
    }
}
