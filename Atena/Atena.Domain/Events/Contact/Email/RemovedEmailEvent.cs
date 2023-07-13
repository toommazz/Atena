using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedEmailEvent : EventCore<Email>
    {
        public RemovedEmailEvent(Email _entity) : base(_entity)
        {
        }
    }
}
