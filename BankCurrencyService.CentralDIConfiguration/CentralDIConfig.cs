using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankCurrencyService.CentralDIConfiguration
{
    public static class CentralDIConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            // this line give ability to IoC to resolve Lazy
            services.AddTransient(typeof(Lazy<>), typeof(Lazier<>));

            new Data.Config().Configure(services, configuration);
            new Service.Config().Configure(services, configuration);
        }
    }

    internal class Lazier<T> : Lazy<T> where T : class
    {
        public Lazier(IServiceProvider provider)
            : base(() => provider.GetRequiredService<T>())
        {
        }
    }
}