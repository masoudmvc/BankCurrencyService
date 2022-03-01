using BankCurrencyService.Data.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankCurrencyService.Data
{
    public class Config
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            #region Sqlite
            //public string DbPath { get; }

            ////C:\Users\masou\AppData\Local\blogging.db
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");

            //options.UseSqlite($"Data Source={DbPath}");
            #endregion

            var connection = configuration["ConnectionString:BankCurrencyServiceDbContext"];
            services.AddDbContext<BankCurrencyDbContext>(options => options
                .UseSqlServer(connection));

            services.AddScoped<BankCurrencyDbContext>();
            services.AddScoped<IAuditSaver, AuditSaver>();
        }
    }
}
