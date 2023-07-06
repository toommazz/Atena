using Atena.Domain.Commands.Contact.PhoneType;

namespace Atena.Domain.Validations.Contact.PhoneType
{
    public class RemovePhoneTypeValidation : PhoneTypeValidation<RemovePhoneTypeCommand>
    {
        public RemovePhoneTypeValidation() 
        {
            ValidateId();
        }
    }
}
