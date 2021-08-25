using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsCatalog.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<T> GetAsync(Guid id);
        Task InsertAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteRowAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> SaveRangeAsync(IEnumerable<T> list);
    }
}