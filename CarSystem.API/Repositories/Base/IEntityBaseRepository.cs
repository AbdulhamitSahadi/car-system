using System.Linq.Expressions;

namespace CarSystem.API.Repositories.Base
{
    public interface IEntityBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, string? includeProperties = null);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, string? includeProperties = null, bool tracked = true);
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate = null);
    }
}
