using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateAddressEvent : EventCore<Address>
    {
        public UpdateAddressEvent(Address _entity) : base(_entity)
        {
        }
    }
}
