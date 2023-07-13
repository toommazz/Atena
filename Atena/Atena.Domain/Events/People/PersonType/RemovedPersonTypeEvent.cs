using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedPersonTypeEvent : EventCore<PersonType>
    {
        public RemovedPersonTypeEvent(PersonType _entity) : base(_entity)
        {
        }
    }
}
