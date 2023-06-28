using Atena.Domain.Core.Model;

namespace Atena.Domain.Core.Events
{
    public class EventCore<TEntity> : Event where TEntity : Entity
    {
        public TEntity entity { get; set; }

        public EventCore(TEntity _entity) 
        {
            entity = _entity;
        }
    }
}
