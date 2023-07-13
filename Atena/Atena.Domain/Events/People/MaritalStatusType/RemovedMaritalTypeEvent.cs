using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedMaritalTypeEvent : EventCore<MaritalStatusType>
    {
        public RemovedMaritalTypeEvent(MaritalStatusType _entity) : base(_entity)
        {
        }
    }
}
