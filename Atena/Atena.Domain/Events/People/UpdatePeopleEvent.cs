using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdatePeopleEvent : EventCore<People>
    {
        public UpdatePeopleEvent(People _entity) : base(_entity)
        {
        }
    }
}
