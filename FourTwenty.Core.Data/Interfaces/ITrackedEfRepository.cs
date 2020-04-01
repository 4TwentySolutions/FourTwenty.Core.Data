using System.Threading.Tasks;
using FourTwenty.Core.Data.Models;

namespace FourTwenty.Core.Data.Interfaces
{
    public interface ITrackedEfRepository<T> : IRepository<T>, IAsyncRepository<T>
    {
        Task Save();
    }
    public interface ITrackedEfRepository<T, in TKey> : IRepository<T, TKey>, IAsyncRepository<T, TKey> where T : BaseEntity<TKey>
    {
        Task Save();
    }
}
