using Atena.Domain.Core.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Atena.Domain.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>> filter = null);

        Task<TEntity> GetOneAsync(
            Expression<Func<TEntity, bool>> filter = null, ICollection<TEntity> include = null,
            Func<Expression<Func<TEntity, bool>>, TEntity> whenNoExists = null);

        Task<TEntity> GetLastOneAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<Expression<Func<TEntity, bool>>, TEntity> whenNoExists = null);

        Task<PagedList<TEntity>> GetAllPagedAsync(Order order, Page page, ICollection<string> include = null,
           Expression<Func<TEntity, bool>> filter = null);

        ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity);

        Task<EntityEntry<TEntity>> UpdateAsync(Guid? id);

        Task<EntityEntry<TEntity>> RemoveAsync(Guid? id);

        Task<TEntity> GetByIdAsync(Guid? id);

        Task<bool> ExistsByExpressionAsync(Expression<Func<TEntity, bool>> expression);

    }
}
