using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class RemoveMaritalTypeValidation : MaritalTypeValidation<RemoveMaritalTypeCommand>
    {
        public RemoveMaritalTypeValidation() 
        {
            ValidateId();
        }
    }
}
