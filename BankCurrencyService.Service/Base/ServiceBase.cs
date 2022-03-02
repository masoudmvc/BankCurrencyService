namespace BankCurrencyService.Service.Base
{
    public abstract class ServiceBase : IBusinessService
    {
        protected readonly IServiceEssentials<ServiceBase> _essentials;

        protected ServiceBase(IServiceEssentials<ServiceBase> essentials)
        {
            _essentials = essentials;
        }
    }
}
