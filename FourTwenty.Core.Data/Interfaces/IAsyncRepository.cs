﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FourTwenty.Core.Data.Models;

namespace FourTwenty.Core.Data.Interfaces
{
    public interface IAsyncRepository<T, in TKey> : IAsyncRepository<T> where T : BaseEntity<TKey>
    {
        Task<T> GetByIdAsync(TKey id);
        Task DeleteAsync(TKey key);
    }

    public interface IAsyncRepository<T>
    {
        Task<T> GetSingleBySpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync();
        Task<int> CountAsync(ISpecification<T> spec);
        Task DeleteRangeAsync(IEnumerable<T> entity);
    }
}


