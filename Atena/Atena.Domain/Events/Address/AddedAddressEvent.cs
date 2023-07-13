using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedAddressEvent : EventCore<Address>
    {
        public AddedAddressEvent(Address _entity) : base(_entity)
        {
        }
    }
}
