using Microsoft.EntityFrameworkCore;

namespace BankCurrencyService.Data.Helper
{
    public interface IAuditSaver
    {
        void SaveChanges(DbContext dbContext, CancellationToken cancelToken);
    }
}
