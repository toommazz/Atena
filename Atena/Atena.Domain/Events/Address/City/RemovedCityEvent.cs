using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedCityEvent : EventCore<City>
    {
        public RemovedCityEvent(City _entity) : base(_entity)
        {
        }
    }
}
