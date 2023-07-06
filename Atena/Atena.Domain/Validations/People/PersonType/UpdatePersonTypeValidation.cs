using Atena.Domain.Commands.People.PersonType;

namespace Atena.Domain.Validations.People.PersonType
{
    public class UpdatePersonTypeValidation : PersonTypeValidation<UpdatePersonTypeCommand>
    {
        public UpdatePersonTypeValidation() 
        {
            ValidateId();
            Validate();
        
        }
    }
}
