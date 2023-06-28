using MediatR;

namespace Atena.Domain.Core.Events
{
    public abstract class Event : CommandMessage, INotification
    {
        public DateTime TimeStamp { get; private set; }

        public Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
