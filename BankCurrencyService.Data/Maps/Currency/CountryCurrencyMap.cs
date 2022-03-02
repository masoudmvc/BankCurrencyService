using BankCurrencyService.Common.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CCNS = BankCurrencyService.Domain.Entities.Currency;

namespace BankCurrencyService.Data.Maps.Currency
{
    public class CountryCurrencyMap : IEntityTypeConfiguration<CCNS.CountryCurrency>
    {
        public void Configure(EntityTypeBuilder<CCNS.CountryCurrency> builder)
        {
            builder.HasKey(p => p.Key);
            builder.Property(p => p.CountryName).IsRequired().HasMaxLength(ValidationConstants.CountryName);
            builder.Property(p => p.AcronymAbb).IsRequired().HasMaxLength(ValidationConstants.AcronymAbb);

            new CountryCurrencySeed(builder).Seed();
        }
    }
}
