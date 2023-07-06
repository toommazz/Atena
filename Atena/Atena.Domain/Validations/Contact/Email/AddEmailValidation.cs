using Atena.Domain.Commands.Contact.Email;

namespace Atena.Domain.Validations.Contact.Email
{
    public class AddEmailValidation : EmailValidation<AddEmailCommand>
    {
        public AddEmailValidation() 
        {
            Validate();
        }
    }
}
