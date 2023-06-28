using Atena.Domain.Core.Data;
using Atena.Domain.Core.Models;
using System.Linq.Expressions;

namespace Atena.Domain.Core.Repositories
{
    public interface IEventStoreRepository
    {
        Task<List<EventStore>> GetAllAsync(
        Order order,
        Page page,
        Expression<Func<EventStore, bool>> filter = null,
            Func<Expression<Func<EventStore, bool>>, PagedList<EventStore>> whenNoExists = null);
        Task<EventStore> GetOneAsync(
        Expression<Func<EventStore, bool>> filter = null,
            Func<Expression<Func<EventStore, bool>>, EventStore> whenNoExists = null);

        Task<EventStore> GetLastOneAsync(
        Expression<Func<EventStore, bool>> filter = null,
            Func<Expression<Func<EventStore, bool>>, EventStore> whenNoExists = null);

        Task AddAsync(EventStore entity);

        Task UpdateAsync(string key, EventStore entity);

        Task UpdateAsync(Guid key, EventStore entity);

        Task RemoveAsync(string key);
        Task RemoveAsync(Guid key);
        Task<EventStore> GetByIdAsync(Guid id);

        Task<bool> ExistsByExpressionAsync(Expression<Func<EventStore, bool>> expression);

        Task<long> CountAllAsync(
        Expression<Func<EventStore, bool>> filter = null,
            Func<Expression<Func<EventStore, bool>>, List<EventStore>> whenNoExists = null);
    }
}
