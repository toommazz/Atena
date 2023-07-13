using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedPhoneEvent : EventCore<Phone>
    {
        public RemovedPhoneEvent(Phone _entity) : base(_entity)
        {
        }
    }
}
