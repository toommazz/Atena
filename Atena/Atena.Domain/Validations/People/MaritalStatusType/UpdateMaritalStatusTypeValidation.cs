using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class UpdateMaritalStatusTypeValidation : MaritalStatusTypeValidation<UpdateMaritalStatusTypeCommand>
    {
        public UpdateMaritalStatusTypeValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
