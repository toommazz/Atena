using Atena.Domain.Commands.Contact.Phone;

namespace Atena.Domain.Validations.Contact.Phone
{
    public class AddPhoneValidation : PhoneValidation<AddPhoneCommand>
    {
        public AddPhoneValidation() 
        {
            Validate();
        }
    }
}
