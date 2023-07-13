using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
    public class RemovedClientEvent : EventCore<Client>
    {
        public RemovedClientEvent(Client _entity) : base(_entity)
        {
        }
    }
}
