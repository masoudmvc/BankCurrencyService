using BankCurrencyService.Data.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankCurrencyService.CentralDIConfiguration
{
    public static class CentralDIConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            Data.Config.Configure(services, configuration);
        }
    }
}