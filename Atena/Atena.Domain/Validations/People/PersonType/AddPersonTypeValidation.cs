using Atena.Domain.Commands.People.PersonType;

namespace Atena.Domain.Validations.People.PersonType
{
    public class AddPersonTypeValidation : PersonTypeValidation<AddPersonTypeCommand>
    {
        public AddPersonTypeValidation() 
        {
            Validate();
        }
    }
}
