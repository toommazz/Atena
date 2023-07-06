using Atena.Domain.Commands.People.GenderType;

namespace Atena.Domain.Validations.People.GenderType
{
    public class AddGenderTypeValidation : GenderTypeValidation<AddGenderTypeCommand>
    {
        public AddGenderTypeValidation() 
        {
            Validate();
        }
    }
}
