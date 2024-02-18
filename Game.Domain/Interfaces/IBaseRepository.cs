using Game.Domain.Entities;
using System.Linq.Expressions;

namespace Game.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> FindByIdAsync(int Id);
        Task<List<T>> FindAllActiveAsync();
        Task<List<T>> FindAllAsync();
        Task<List<T>> FindAllActiveAsNoTrackingAsync();
        Task<List<T>> FindAllAsNoTrackingAsync();
        Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> FindByConditionFirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entites);
        Task UpdateAsync(T entity);
        Task DeActivate(T entity);
    }
}
