using Atena.Domain.Core.Events;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Models;
using Atena.Domain.Core.Repositories;
using MediatR;
using System.Security.Claims;

namespace Atena.Domain.Core.EventHandler
{
    public abstract class EventHandler<TEvent, TEntity>
        : INotificationHandler<TEvent>
        where TEvent : EventCore<TEntity>
        where TEntity : Entity
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly ClaimsPrincipal _user;

        public EventHandler(IEventStoreRepository eventStoryRepository, ClaimsPrincipal user)
        {
            _user = user;
            _eventStoreRepository = eventStoryRepository;
        }

        public async Task Handle(TEvent notification, CancellationToken cancellationToken)
        {
            await ApplyEvent(notification);
        }

        private async Task ApplyEvent(TEvent notificationEvent)
        {
            var eventStore = new EventStore(
                notificationEvent.GetType().Name,
                Guid.NewGuid(), //TODO: Pendente de alinhamento de negócio
                "pendente", //TODO: Pendente de alinhamento de negócio
                DateTime.Now,
                notificationEvent.entity,
                Guid.NewGuid());

            await _eventStoreRepository.AddAsync(eventStore);

            PublishEvent(notificationEvent.entity);
        }

        public virtual async Task PublishEvent(TEntity message)
        {

        }
    }
}
