using Atena.Domain.Commands.Contact.Phone;

namespace Atena.Domain.Validations.Contact.Phone
{
    public class RemovePhoneValidation : PhoneValidation<RemovePhoneCommand>
    {
        public RemovePhoneValidation() 
        {
            ValidateId();
        }
    }
}
