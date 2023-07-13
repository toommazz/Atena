using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class RemoveMaritalStatusTypeValidation : MaritalStatusTypeValidation<RemoveMaritalStatusTypeCommand>
    {
        public RemoveMaritalStatusTypeValidation() 
        {
            ValidateId();
        }
    }
}
