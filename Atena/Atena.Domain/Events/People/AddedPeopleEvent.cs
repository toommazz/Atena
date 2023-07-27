using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{ 
    public class AddedPeopleEvent : EventCore<People>
    {
        public AddedPeopleEvent(People _entity) : base(_entity)
        {
        }
    }
}
