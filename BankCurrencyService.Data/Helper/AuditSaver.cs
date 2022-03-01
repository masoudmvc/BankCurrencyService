using BankCurrencyService.Domain;
using BankCurrencyService.Domain.Entities.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BankCurrencyService.Data.Helper
{
    public class AuditSaver : IAuditSaver
    {
        public void SaveChanges(DbContext dbContext, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;

            dbContext.ChangeTracker.DetectChanges();

            var entitiesToChange = dbContext.ChangeTracker.Entries()
              .Where(e => e.State == EntityState.Added ||
                          e.State == EntityState.Modified ||
                          e.State == EntityState.Deleted)
              .ToArray();

            var entriesToKeepHistory = entitiesToChange
           .Where(e => e.Entity is IAuditableEntity)
           .ToArray();

            foreach (var entry in entriesToKeepHistory.ToList())
            {
                var entity = entry.Entity as EntityBase<Guid>;

                var history = new Audit
                {
                    Action = GetAction(entry.State),
                    CreatedDate = now,
                    EntityId = entity?.Key.ToString(),
                    EntityType = entry.Entity?.GetType().Name,
                    Value = ToJson(entry.Entity ?? string.Empty)
                };

                dbContext.AddAsync(history, cancellationToken);
            }

            SetEntitiesMetaData(dbContext, entitiesToChange, now);
        }

        private void SetEntitiesMetaData(DbContext dbContext, IEnumerable<EntityEntry> entitiesToChange, DateTime now)
        {
            foreach (var entry in entitiesToChange)
            {
                if (entry.Entity is not IEntity entity) continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        {
                            if (string.IsNullOrWhiteSpace(entity.Creator)) entity.Creator = null;
                            if (entity.CreatedDate == default) entity.CreatedDate = now;

                            break;
                        }
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        {
                            dbContext.Entry(entity).Property(nameof(IEntity.Creator)).IsModified = false;
                            dbContext.Entry(entity).Property(nameof(IEntity.CreatedDate)).IsModified = false;
                            if (string.IsNullOrWhiteSpace(entity.LastUpdater)) entity.LastUpdater = null;
                            if (entity.LastUpdatedDate == default(DateTime)) entity.LastUpdatedDate = now;
                            break;
                        }
                }
            }
        }

        private static string ToJson(object entryEntity)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(entryEntity,
                new Newtonsoft.Json.JsonSerializerSettings
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
        }
        private static AuditAction GetAction(EntityState entryState)
        {
            switch (entryState)
            {
                case EntityState.Added:
                    return AuditAction.Create;
                case EntityState.Modified:
                    return AuditAction.Update;
                case EntityState.Deleted:
                    return AuditAction.Delete;
                default:
                    return 0;
            }
        }
    }
}
