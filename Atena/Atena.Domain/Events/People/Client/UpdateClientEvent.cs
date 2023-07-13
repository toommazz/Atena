using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateClientEvent : EventCore<Client>
    {
        public UpdateClientEvent(Client _entity) : base(_entity)
        {
        }
    }
}
