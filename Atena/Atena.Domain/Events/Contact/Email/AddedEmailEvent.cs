using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedEmailEvent : EventCore<Email>
    {
        public AddedEmailEvent(Email _entity) : base(_entity)
        {
        }
    }
}
