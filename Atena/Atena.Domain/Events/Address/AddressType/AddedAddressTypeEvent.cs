using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedAddressTypeEvent : EventCore<AddressType>
    {
        public AddedAddressTypeEvent(AddressType _entity) : base(_entity)
        {
        }
    }
}
