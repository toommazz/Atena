using Atena.Domain.Commands.Address.City;

namespace Atena.Domain.Validations.Address.City
{
    public class RemoveCityValidation : CityValidation<CityCommand>
    {
        public RemoveCityValidation() 
        {
            ValidateId();
        
        }
    }
}
