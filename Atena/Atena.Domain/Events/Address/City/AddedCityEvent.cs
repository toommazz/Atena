using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedCityEvent : EventCore<City>
    {
        public AddedCityEvent(City _entity) : base(_entity)
        {
        }
    }
}
