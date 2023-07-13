using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedAddressTypeEvent : EventCore<AddressType>
    {
        public RemovedAddressTypeEvent(AddressType _entity) : base(_entity)
        {
        }
    }
}
