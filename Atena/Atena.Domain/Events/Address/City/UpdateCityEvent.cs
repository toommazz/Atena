using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateCityEvent : EventCore<City>
    {
        public UpdateCityEvent(City _entity) : base(_entity)
        {
        }
    }
}
