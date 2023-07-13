using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateStateEvent : EventCore<State>
    {
        public UpdateStateEvent(State _entity) : base(_entity)
        {
        }
    }
}
