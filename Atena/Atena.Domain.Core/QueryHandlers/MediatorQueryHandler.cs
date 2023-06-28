using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using MediatR;

namespace Atena.Domain.Core.QueryHandlers
{
    public abstract class MediatorQueryHandler<TQuery, TResponse>
        : IRequestHandler<TQuery, TResponse>
        where TQuery : Query<TResponse>
        where TResponse : class
    {
        protected IMediatorHandler _mediator { get; }

        public MediatorQueryHandler(IMediatorHandler mediator)
        {
            _mediator = mediator;
        }

        public abstract Task<TResponse> AfterValidation(TQuery request);

        public Task<TResponse> Handle(TQuery request, CancellationToken cancellationToken)
        {
            if(!request.IsValid())
            {
                NotifyValidationErrors(request);

                return Task.FromResult<TResponse>(null);
            }

            return AfterValidation(request);
        }

        protected void NotifyValidationErrors(TQuery message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _mediator.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        protected void NotifyError(string code, string message) 
        { 
            _mediator.RaiseEvent(new DomainNotification(code, message));
        }

        protected void NotifyError(string message) => NotifyError(string.Empty, message);

        protected void NotifyError(IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
                NotifyError(message);
            }
        }

        protected bool HasNotification() => _mediator.HasNotification();

        protected IEnumerable<string> Errors => ((DomainNotificationHandler)_mediator.GetNotificationHandler())
            .GetNotifications()
            .Select(t => t.Value);
    }
}
