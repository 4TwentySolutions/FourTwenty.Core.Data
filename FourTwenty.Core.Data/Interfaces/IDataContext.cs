using System.Threading;
using System.Threading.Tasks;

namespace FourTwenty.Core.Data.Interfaces
{
    public partial interface IDataContext 
    {

        #region Transaction

        Task BeginTransactionAsync(CancellationToken token = default);
        void BeginTransaction();
        void Commit();
        Task CommitAsync(CancellationToken token = default);
        void Rollback();
        Task RollbackAsync(CancellationToken token = default);

        #endregion
    }
}
