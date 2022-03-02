using BankCurrencyService.Common.Constants;
using BankCurrencyService.Domain.Entities.Rate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankCurrencyService.Data.Maps.Rate
{
    public class ExchangeRateResourceMap : IEntityTypeConfiguration<ExchangeRateResource>
    {
        public void Configure(EntityTypeBuilder<ExchangeRateResource> builder)
        {
            builder.HasKey(p => p.Key);

            new ExchangeRateResourceSeed(builder).Seed();
        }
    }
}
