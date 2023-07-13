using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedPhoneTypeEvent : EventCore<PhoneType>
    {
        public RemovedPhoneTypeEvent(PhoneType _entity) : base(_entity)
        {
        }
    }
}
