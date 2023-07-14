using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateMaritalStatusTypeEvent : EventCore<MaritalStatusType>
    {
        public UpdateMaritalStatusTypeEvent(MaritalStatusType _entity) : base(_entity)
        {
        }
    }
}
