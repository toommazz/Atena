using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedMaritalStatusTypeEvent : EventCore<MaritalStatusType>
    {
        public AddedMaritalStatusTypeEvent(MaritalStatusType _entity) : base(_entity)
        {
        }
    }
}
