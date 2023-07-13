using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedStateEvent : EventCore<State>
    {
        public AddedStateEvent(State _entity) : base(_entity)
        {
        }
    }
}
