using System.Linq.Expressions;

namespace EKSystemApp.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<T?> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task Remove(T entitiy);
    }
}
