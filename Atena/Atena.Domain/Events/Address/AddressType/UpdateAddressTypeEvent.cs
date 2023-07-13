using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateAddressTypeEvent : EventCore<AddressType>
    {
        public UpdateAddressTypeEvent(AddressType _entity) : base(_entity)
        {
        }
    }
}
