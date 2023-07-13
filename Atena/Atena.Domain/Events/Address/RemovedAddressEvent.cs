using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedAddressEvent : EventCore<Address>
    {
        public RemovedAddressEvent(Address _entity) : base(_entity)
        {
        }
    }
}
