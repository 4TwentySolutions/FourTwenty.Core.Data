using System.Threading;
using System.Threading.Tasks;
using FourTwenty.Core.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FourTwenty.Core.Data.Repositories
{
    public class EfDbContext : DbContext, IEfDataContext
    {
        public EfDbContext(DbContextOptions options) : base(options)
        {

        }

        public EfDbContext()
        {

        }

        #region transactions
        protected IDbContextTransaction Transaction;
        public virtual void BeginTransaction()
        {
            Transaction = Database.BeginTransaction();
        }

        public virtual async Task BeginTransactionAsync(CancellationToken token = default)
        {
            Transaction = await Database.BeginTransactionAsync(token);
        }
        public virtual void Commit()
        {
            try
            {
                SaveChanges();
                Transaction?.Commit();
            }
            finally
            {
                Transaction?.Dispose();
                Transaction = null;
            }
        }

        public virtual async Task CommitAsync(CancellationToken token = default)
        {
            try
            {
                await SaveChangesAsync(token);
                if (Transaction != null)
                    await Transaction.CommitAsync(token);
            }
            finally
            {
                if (Transaction != null)
                {
                    await Transaction.DisposeAsync();
                    Transaction = null;
                }
            }
        }

        public virtual void Rollback()
        {
            if (Transaction == null)
                return;

            Transaction.Rollback();
            Transaction.Dispose();
            Transaction = null;
        }
        public virtual async Task RollbackAsync(CancellationToken token = default)
        {
            if (Transaction == null)
                return;

            await Transaction.RollbackAsync(token);
            await Transaction.DisposeAsync();
            Transaction = null;
        }
        #endregion
    }
}
