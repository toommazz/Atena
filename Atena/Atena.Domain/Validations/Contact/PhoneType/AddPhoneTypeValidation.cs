using Atena.Domain.Commands.Contact.PhoneType;

namespace Atena.Domain.Validations.Contact.PhoneType
{
    public class AddPhoneTypeValidation : PhoneTypeValidation<AddPhoneTypeCommand>
    {
        public AddPhoneTypeValidation() 
        {
            Validate();
        }
    }
}
