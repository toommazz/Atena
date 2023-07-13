using Atena.Domain.Core.EventHandler;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using System.Security.Claims;

namespace Atena.Domain.EventHandlers
{
    public class RemovedAddressTypeEventHandler : EventHandler<RemovedAddressTypeEvent, AddressType>
    {
        public RemovedAddressTypeEventHandler(IEventStoreRepository eventStoryRepository, ClaimsPrincipal user) : base(eventStoryRepository, user)
        {
        }
    }
}
