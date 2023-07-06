using Atena.Domain.Commands.Contact.Phone;

namespace Atena.Domain.Validations.Contact.Phone
{
    public class UpdatePhoneValidation : PhoneValidation<UpdatePhoneCommand>
    {
        public UpdatePhoneValidation() 
        
        {
            ValidateId();
            Validate();
        }
    }
}
