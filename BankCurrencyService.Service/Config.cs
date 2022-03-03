using BankCurrencyService.Common.Contracts;
using BankCurrencyService.Service.Base;
using BankCurrencyService.Service.Currency;
using BankCurrencyService.Service.Rate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankCurrencyService.Service
{
    public class Config : IConfig
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(ServiceBase).Assembly);

            services.AddScoped(typeof(IServiceEssentials<>), typeof(ServiceEssentials<>));
            services.AddScoped<IExchangeRateService, ExchangeRateService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
        }
    }
}
