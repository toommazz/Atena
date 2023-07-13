using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Event
{
    public class UpdateGenderTypeEvent : EventCore<GenderType>
    {
        public UpdateGenderTypeEvent(GenderType _entity) : base(_entity)
        {
        }
    }
}
