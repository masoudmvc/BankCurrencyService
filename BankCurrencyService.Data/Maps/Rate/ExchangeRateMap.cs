using BankCurrencyService.Domain.Entities.Rate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankCurrencyService.Data.Maps.Rate
{
    public class ExchangeRateMap : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.HasKey(p => p.Key);

        }
    }
}
