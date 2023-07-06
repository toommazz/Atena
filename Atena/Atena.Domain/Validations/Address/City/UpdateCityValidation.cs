using Atena.Domain.Commands.Address.City;

namespace Atena.Domain.Validations.Address.City
{
    public class UpdateCityValidation : CityValidation<UpdateCityCommand>
    {
        public UpdateCityValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
