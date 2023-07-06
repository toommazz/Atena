
using Atena.Domain.Commands.Address.City;

namespace Atena.Domain.Validations.Address.City
{
    public class AddCityValidation : CityValidation<CityCommand>
    {
        public AddCityValidation() 
        {
            Validate();
        }
    }
}
