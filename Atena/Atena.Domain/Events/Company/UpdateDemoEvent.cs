using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateCompanyEvent : EventCore<Company>
    {
        public UpdateCompanyEvent(Company _entity) : base(_entity) { }
    }
}
