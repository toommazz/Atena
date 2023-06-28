using Atena.Domain.Core.Events;
using Atena.Domain.Core.Notifications;
using MediatR;

namespace Atena.Domain.Core.Interfaces.MediatorR
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task<TResponse> SendQuery<TResponse>(Query<TResponse> query) where TResponse : class;

        Task RaiseEvent<T>(T @event) where T : Event;

        bool HasNotification();

        INotificationHandler<DomainNotification> GetNotificationHandler();
    }
}
