using BankCurrencyService.Common.Constants;
using BankCurrencyService.Domain.Entities.Rate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankCurrencyService.Data.Maps.Rate
{
    public class ExchangeRateDetailMap : IEntityTypeConfiguration<ExchangeRateDetail>
    {
        public void Configure(EntityTypeBuilder<ExchangeRateDetail> builder)
        {
            builder.HasKey(p => p.Key);

            builder.Property(x => x.Rate).HasColumnType("decimal(10,5)");
            builder.Property(x => x.Currency).IsRequired().HasMaxLength(ValidationConstants.Currency);
        }
    }
}
