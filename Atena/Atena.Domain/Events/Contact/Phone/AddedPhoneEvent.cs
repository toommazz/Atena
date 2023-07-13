using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedPhoneEvent : EventCore<Phone>
    {
        public AddedPhoneEvent(Phone _entity) : base(_entity)
        {
        }
    }
}
