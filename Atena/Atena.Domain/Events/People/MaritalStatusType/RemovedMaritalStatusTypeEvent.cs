using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedMaritalStatusTypeEvent : EventCore<MaritalStatusType>
    {
        public RemovedMaritalStatusTypeEvent(MaritalStatusType _entity) : base(_entity)
        {
        }
    }
}
