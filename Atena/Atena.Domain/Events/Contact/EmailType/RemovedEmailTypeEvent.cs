using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedEmailTypeEvent : EventCore<EmailType>
    {
        public RemovedEmailTypeEvent(EmailType _entity) : base(_entity)
        {
        }
    }
}
