using Atena.Domain.Commands.People.MaritalType;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class AddMaritalTypeValidation : MaritalTypeValidation<AddMaritalTypeCommand>
    {   
        public AddMaritalTypeValidation() 
        {
            Validate();
        }
    }
}
