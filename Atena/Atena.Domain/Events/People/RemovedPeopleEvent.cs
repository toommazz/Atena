using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{ 
    public class RemovedPeopleEvent : EventCore<People>
    {
        public RemovedPeopleEvent(People _entity) : base(_entity)
        {
        }
    }
}
