using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedGenderTypeEvent : EventCore<GenderType>
    {
        public RemovedGenderTypeEvent(GenderType _entity) : base(_entity)
        {
        }
    }
}
