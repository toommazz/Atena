using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class AddMaritalStatusTypeValidation : MaritalStatusTypeValidation<AddMaritalStatusTypeCommand>
    {   
        public AddMaritalStatusTypeValidation() 
        {
            Validate();
        }
    }
}
