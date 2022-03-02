using AutoMapper;
using Microsoft.Extensions.Logging;

namespace BankCurrencyService.Service.Base
{
    public interface IServiceEssentials<out TService> where TService : ServiceBase
    {
        ILogger<TService> Logger { get; }
        IMapper Mapper { get; }
    }

    public class ServiceEssentials<TService> : IServiceEssentials<TService> where TService : ServiceBase
    {
        private readonly Lazy<ILogger<TService>> _lzLogger;
        public ILogger<TService> Logger => _lzLogger.Value;
        public IMapper Mapper { get; private set; }
        
        public ServiceEssentials(Lazy<ILogger<TService>> lzLogger, IMapper mapper)
        {
            _lzLogger = lzLogger;
            Mapper = mapper;
        }
    }
}
