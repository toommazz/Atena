using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdatePhoneEvent : EventCore<Phone>
    {
        public UpdatePhoneEvent(Phone _entity) : base(_entity)
        {
        }
    }
}
