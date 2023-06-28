using Atena.Domain.Core.Model;

namespace Atena.Domain.Core.Querys
{
    public abstract class GetQuery<TEntity>
        : QueryCore<TEntity> where TEntity : Entity
    {
        public override bool IsValid()
        {
            return true;
        }
    }
}
