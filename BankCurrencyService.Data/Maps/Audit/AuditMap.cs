using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ADNS = BankCurrencyService.Domain.Entities.Audit;

namespace BankCurrencyService.Data.Maps.Audit
{
    public class AuditMap : IEntityTypeConfiguration<ADNS.Audit>
    {
        public void Configure(EntityTypeBuilder<ADNS.Audit> builder)
        {
            builder.HasKey(p => p.Key);
        }
    }
}

