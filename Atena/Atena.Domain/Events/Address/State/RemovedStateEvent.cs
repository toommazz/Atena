using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedStateEvent : EventCore<State>
    {
        public RemovedStateEvent(State _entity) : base(_entity)
        {
        }
    }
}
