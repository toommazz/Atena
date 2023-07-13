using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedEmailTypeEvent : EventCore<EmailType>
    {
        public AddedEmailTypeEvent(EmailType _entity) : base(_entity)
        {
        }
    }
}
