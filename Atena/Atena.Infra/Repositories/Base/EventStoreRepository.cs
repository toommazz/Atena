using Atena.Domain.Core.Data;
using Atena.Domain.Core.Models;
using Atena.Domain.Core.Repositories;
using Atena.Infra.Contexts.Base;
using System.Linq.Expressions;

namespace Atena.Infra.Repositories.Base
{
    public class EventStoreRepository : IEventStoreRepository
    {
        private readonly AtenaDataContext _context;

        public EventStoreRepository(AtenaDataContext context)
        {
            _context = context;
        }

        public Task AddAsync(EventStore entity)
        {
            return Task.CompletedTask;
        }

        public Task<long> CountAllAsync(Expression<Func<EventStore, bool>> filter = null, Func<Expression<Func<EventStore, bool>>, List<EventStore>> whenNoExists = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByExpressionAsync(Expression<Func<EventStore, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<EventStore>> GetAllAsync(Order order, Page page, Expression<Func<EventStore, bool>> filter = null, Func<Expression<Func<EventStore, bool>>, PagedList<EventStore>> whenNoExists = null)
        {
            throw new NotImplementedException();
        }

        public Task<EventStore> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EventStore> GetLastOneAsync(Expression<Func<EventStore, bool>> filter = null, Func<Expression<Func<EventStore, bool>>, EventStore> whenNoExists = null)
        {
            throw new NotImplementedException();
        }

        public Task<EventStore> GetOneAsync(Expression<Func<EventStore, bool>> filter = null, Func<Expression<Func<EventStore, bool>>, EventStore> whenNoExists = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string key, EventStore entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid key, EventStore entity)
        {
            throw new NotImplementedException();
        }
    }
}
