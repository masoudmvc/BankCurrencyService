using BankCurrencyService.Domain.Entities.Rate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankCurrencyService.Data.Maps.Rate
{
    public class ExchangeRateResourceSeed
    {
        private readonly EntityTypeBuilder<ExchangeRateResource> _builder;

        public ExchangeRateResourceSeed(EntityTypeBuilder<ExchangeRateResource> builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            var data = new List<ExchangeRateResource>
            {
                new ExchangeRateResource
                {
                    Key = Guid.Parse("DB1D8AB3-A521-4F6C-8C94-729CE1EA491D"),
                    ResourceName = "Europesn Central Bank",
                    ApiKey = null,
                    ResourceUri = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?4610f020d7463a0cd43d6828905faf2f"
                }
            };

            _builder.HasData(data);
        }
    }
}
