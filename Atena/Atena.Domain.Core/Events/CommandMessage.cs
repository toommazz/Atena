using Atena.Domain.Core.Interfaces;
using MediatR;

namespace Atena.Domain.Core.Events
{
    public abstract class CommandMessage : IRequest, IRequestBase

    {
        public string MessageType { get; protected set; }

        protected CommandMessage() 
        { 
            MessageType = GetType().Name;
        }
    }
}
