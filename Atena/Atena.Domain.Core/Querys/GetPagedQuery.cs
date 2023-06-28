using Atena.Domain.Core.Data;
using Atena.Domain.Core.Model;
using System.Linq.Expressions;

namespace Atena.Domain.Core.Querys
{
    public abstract  class GetPagedQuery<TEntity>
        : QueryCore<PagedList<TEntity>>
        where TEntity : Entity
    {
        public Expression<Func<TEntity, bool>> Filter = null;

        public override bool IsValid()
        {
            return true;
        }
    }
}
