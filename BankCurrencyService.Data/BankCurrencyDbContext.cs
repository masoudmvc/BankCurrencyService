using BankCurrencyService.Data.Helper;
using BankCurrencyService.Domain;
using Microsoft.EntityFrameworkCore;

namespace BankCurrencyService.Data
{
    public class BankCurrencyDbContext : DbContext
    {
        private readonly IAuditSaver _auditSaver;

        internal static string DefaultSchemaName = "BCS";
        
        public BankCurrencyDbContext(DbContextOptions<BankCurrencyDbContext> options, IAuditSaver auditSaver)
            : base(options)
        {
            _auditSaver = auditSaver;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DefaultSchemaName);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BankCurrencyDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            var entitiesToAdd = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToArray();

            foreach (var entry in entitiesToAdd)
            {
                if (entry.Entity is IEntity entity)
                {
                    entity.CreatedDate = DateTime.UtcNow;
                }
            }

            var entitiesToUpdate = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToArray();

            foreach (var entry in entitiesToUpdate)
            {
                if (entry.Entity is IEntity entity)
                {
                    entity.LastUpdatedDate = DateTime.UtcNow;
                }
            }

            _auditSaver?.SaveChanges(this, cancellationToken);

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
