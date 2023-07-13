using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{ 
    public class AddedClientEvent : EventCore<Client>
    {
        public AddedClientEvent(Client _entity) : base(_entity)
        {
        }
    }
}
