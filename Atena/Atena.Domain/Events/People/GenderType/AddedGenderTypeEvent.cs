using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
    public class AddedGenderTypeEvent : EventCore<GenderType>
    {
        public AddedGenderTypeEvent(GenderType _entity) : base(_entity)
        {
        }
    }
}
