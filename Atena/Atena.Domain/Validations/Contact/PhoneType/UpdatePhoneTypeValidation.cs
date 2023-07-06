using Atena.Domain.Commands.Contact.PhoneType;

namespace Atena.Domain.Validations.Contact.PhoneType
{
    public class UpdatePhoneTypeValidation : PhoneTypeValidation<UpdatePhoneTypeCommand>
    {
        public UpdatePhoneTypeValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
