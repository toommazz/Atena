using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedPersonTypeEvent : EventCore<PersonType>
    {
        public AddedPersonTypeEvent(PersonType _entity) : base(_entity)
        {
        }
    }
}
