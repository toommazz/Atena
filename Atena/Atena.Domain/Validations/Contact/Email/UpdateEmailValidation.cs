using Atena.Domain.Commands.Contact.Email;

namespace Atena.Domain.Validations.Contact.Email
{
    public class UpdateEmailValidation : EmailValidation<UpdateEmailCommand>
    {
        public UpdateEmailValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
