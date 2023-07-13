using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedPhoneTypeEvent : EventCore<PhoneType>
    {
        public AddedPhoneTypeEvent(PhoneType _entity) : base(_entity)
        {
        }
    }
}
