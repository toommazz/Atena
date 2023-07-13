using Atena.Domain.Core.EventHandler;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using System.Security.Claims;

namespace Atena.Domain.EventHandlers
{
    public class AddedCityEventHandler : EventHandler<AddedCityEvent, City>
    {
        public AddedCityEventHandler(IEventStoreRepository eventStoryRepository, ClaimsPrincipal user) : base(eventStoryRepository, user)
        {
        }
    }
}
