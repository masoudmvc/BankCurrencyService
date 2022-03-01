using BankCurrencyService.Domain.Entities.Currency;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BankCurrencyService.Data.Maps.Currency
{
    public class CountryCurrencySeed
    {
        private readonly EntityTypeBuilder<CountryCurrency> _builder;
        public CountryCurrencySeed(EntityTypeBuilder<CountryCurrency> builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            var projectPath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(projectPath, @"Files\CountryCurrency.json");

            var data = JsonConvert.DeserializeObject<List<CountryCurrency>>(File.ReadAllText(filePath));
            
            if (data != null)
                _builder.HasData(data);
        }
    }
}
