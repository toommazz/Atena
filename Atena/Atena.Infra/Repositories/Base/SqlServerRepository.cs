using Atena.Domain.Core.Data;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Repositories;
using Atena.Infra.Contexts.Base;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Atena.Infra.Repositories.Base
{
    public abstract class SqlServerRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly AtenaDataContext _context;

        public SqlServerRepository(AtenaDataContext context)
        {
            _context = context;
        }

        public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity)
        {
            return _context.AddAsync(entity);
        }

        public async Task<bool> ExistsByExpressionAsync(Expression<Func<TEntity, bool>> expression)
        {
            var reg = await GetOneAsync(expression);

            return reg != null;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            var cursor = await _context.FindAsync<IEnumerable<TEntity>>(filter);

            var result = cursor.ToList();

            return result;
        }

        public async Task<PagedList<TEntity>> GetAllPagedAsync(Order order, Page page, Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (order.Crescent)
                query = query.OrderBy(o => o.Id);
            else
                query = query.OrderByDescending(o => o.Id);

            query = query.Skip((page.Index - 1) * page.Quantity).Take(page.Quantity);

            return new PagedList<TEntity>(query.ToList());
        }

        public async Task<TEntity> GetByIdAsync(Guid? id)
        {
            return await GetOneAsync(e => e.Id == id);
        }

        public async Task<TEntity> GetLastOneAsync(Expression<Func<TEntity, bool>> filter = null, Func<Expression<Func<TEntity, bool>>, TEntity> whenNoExists = null)
        {
            var result = await _context.FindAsync<IEnumerable<TEntity>>(filter);

            var resultOrder = result.OrderByDescending(o => o.Id);

            return resultOrder.FirstOrDefault();
        }

        public async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> filter = null, Func<Expression<Func<TEntity, bool>>, TEntity> whenNoExists = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            var cursor = query.Where(filter);

            var result = cursor?.FirstOrDefault();

            return result;
        }

        public async Task<EntityEntry<TEntity>> RemoveAsync(Guid? id)
        {
            var entity = await GetByIdAsync(id);

            return _context.Remove(entity);
        }

        public async Task<EntityEntry<TEntity>> UpdateAsync(Guid? id)
        {
            var entity = await GetByIdAsync(id);

            return _context.Update(entity);
        }
    }
}
