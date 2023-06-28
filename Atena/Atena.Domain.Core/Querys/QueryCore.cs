using Atena.Domain.Core.Data;
using System.Linq.Expressions;

namespace Atena.Domain.Core.Querys
{
    public abstract class QueryCore<TEntity> : Query<TEntity>
    {
        public Guid? Id { get; set; }

        public Page Page { get; set; }

        public Order Order { get; set; }

        public Restriction Restriction { get; set; }
    }
}
