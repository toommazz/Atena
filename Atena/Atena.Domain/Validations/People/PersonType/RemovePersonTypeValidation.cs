
using Atena.Domain.Commands.People.PersonType;

namespace Atena.Domain.Validations.People.PersonType
{
    public class RemovePersonTypeValidation : PersonTypeValidation<RemovePersonTypeCommand>
    {   
        public RemovePersonTypeValidation() 
        {
            ValidateId();
        }
    }
}
