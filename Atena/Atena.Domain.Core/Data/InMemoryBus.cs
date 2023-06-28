using Atena.Domain.Core.Events;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using MediatR;

namespace Atena.Domain.Core.Data
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly DomainNotificationHandler _domainNotification;

        public InMemoryBus(
            IMediator mediator,
            INotificationHandler<DomainNotification> domainNotification)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _domainNotification = (DomainNotificationHandler)domainNotification ??
                throw new ArgumentNullException(nameof(domainNotification));
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public Task<TResponse> SendQuery<TResponse>(Query<TResponse> query) where TResponse : class
        {
            return _mediator.Send(query);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }

        public bool HasNotification()
        {
            return _domainNotification.HasNotifications();
        }

        public INotificationHandler<DomainNotification> GetNotificationHandler()
        {
            return _domainNotification;
        }
    }
}
