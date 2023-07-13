using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateEmailEvent : EventCore<Email>
    {
        public UpdateEmailEvent(Email _entity) : base(_entity)
        {
        }
    }
}
