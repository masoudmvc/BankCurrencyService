using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BankCurrencyService.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<BankCurrencyDbContext>
    {
        private readonly IConfigurationRoot configuration;

        public DbContextFactory()
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(System.AppContext.BaseDirectory)
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }

        public BankCurrencyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankCurrencyDbContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionString:BankCurrencyServiceDbContext"]
               , m => { m.EnableRetryOnFailure(); /*m.MigrationsAssembly("ICD.ChronicKidneyDisease.Api");*/ })
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            return new BankCurrencyDbContext(optionsBuilder.Options, auditSaver: null);
        }
    }
}

