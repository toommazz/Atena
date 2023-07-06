using Atena.Domain.Commands.Contact.EmailType;

namespace Atena.Domain.Validations.Contact.EmailType
{
    public class RemoveEmailTypeValidation : EmailTypeValidation<RemoveEmailTypeCommand>
    {
        public RemoveEmailTypeValidation() 
        {
            ValidateId();
        }
    }
}
