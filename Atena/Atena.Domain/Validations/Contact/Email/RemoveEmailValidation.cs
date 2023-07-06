using Atena.Domain.Commands.Contact.Email;

namespace Atena.Domain.Validations.Contact.Email
{
    public class RemoveEmailValidation : EmailValidation<RemoveEmailCommand>
    {
        public RemoveEmailValidation() 
        {
            ValidateId();
        }
    }
}
