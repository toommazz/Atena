using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class UpdateMaritalTypeValidation : MaritalTypeValidation<UpdateMaritalTypeCommand>
    {
        public UpdateMaritalTypeValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
