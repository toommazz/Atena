using Atena.Domain.Commands.People.GenderType;

namespace Atena.Domain.Validations.People.GenderType
{
    public class UpdateGenderTypeValidation : GenderTypeValidation<UpdateGenderTypeCommand>
    {
        public UpdateGenderTypeValidation() 
        {
            ValidateId();
            Validate();
        
        }
    }
}
