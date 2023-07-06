using Atena.Domain.Commands.People.GenderType;

namespace Atena.Domain.Validations.People.GenderType
{
    public class RemoveGenderTypeValidation : GenderTypeValidation<RemoveGenderTypeCommand>
    {
        public RemoveGenderTypeValidation() 
        {
            ValidateId();
        }
    }
}
