using Atena.Domain.Commands.Contact.EmailType;

namespace Atena.Domain.Validations.Contact.EmailType
{
    public class AddEmailTypeValidation : EmailTypeValidation<AddEmailTypeCommand>
    {
        public AddEmailTypeValidation() 
        {
            Validate();
        }
    }
}
