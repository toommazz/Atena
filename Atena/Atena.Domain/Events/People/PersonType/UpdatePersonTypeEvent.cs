using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{ 
    public class UpdatePersonTypeEvent : EventCore<PersonType>
    {
        public UpdatePersonTypeEvent(PersonType _entity) : base(_entity)
        {
        }
    }
}
