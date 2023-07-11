using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedCompanyEvent : EventCore<Company>
    {
        public RemovedCompanyEvent(Company _entity) : base(_entity) { }
    }
}
