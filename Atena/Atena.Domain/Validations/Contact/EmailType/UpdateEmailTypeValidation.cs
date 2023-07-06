using Atena.Domain.Commands.Contact.EmailType;

namespace Atena.Domain.Validations.Contact.EmailType
{
    public class UpdateEmailTypeValidation : EmailTypeValidation<UpdateEmailTypeCommand>
    {
        public UpdateEmailTypeValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
