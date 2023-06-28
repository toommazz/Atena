using Atena.Domain.Core.Interfaces;
using MediatR;

namespace Atena.Domain.Core.Events
{
    public abstract class QueryMessage<TResponse> : IRequest<TResponse>, IRequestBase
    {
        public string MessageType { get; set; }

        protected QueryMessage()
        {
            MessageType = GetType().Name;
        }
    }
}
