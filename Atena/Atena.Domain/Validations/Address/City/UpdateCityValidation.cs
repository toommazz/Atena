using Atena.Domain.Commands.Address.City;

namespace Atena.Domain.Validations.Address.City
{
    public class UpdateCityValidation : CityValidation<CityCommand>
    {
        public UpdateCityValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
