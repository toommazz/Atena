using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedCompanyEvent : EventCore<Company>
    {
        public AddedCompanyEvent(Company _entity) : base(_entity) { }
    }
}
