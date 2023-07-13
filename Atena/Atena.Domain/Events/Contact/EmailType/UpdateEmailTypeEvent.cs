using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateEmailTypeEvent : EventCore<EmailType>
    {
        public UpdateEmailTypeEvent(EmailType _entity) : base(_entity)
        {
        }
    }
}
