using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateMaritalTypeEvent : EventCore<MaritalStatusType>
    {
        public UpdateMaritalTypeEvent(MaritalStatusType _entity) : base(_entity)
        {
        }
    }
}
