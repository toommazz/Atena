using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdatePhoneTypeEvent : EventCore<PhoneType>
    {
        public UpdatePhoneTypeEvent(PhoneType _entity) : base(_entity)
        {
        }
    }
}
