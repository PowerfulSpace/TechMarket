using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity, Guid id);
        Task<bool> DeleteAsync(Guid id); 
    }
}
