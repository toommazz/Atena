using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Phone;

namespace Atena.Domain.Commands.Contact.Phone
{
    public class AddPhoneCommand : PhoneCommand, IAddCommand
    {
        public AddPhoneCommand(
            Guid? id, 
            string name,
            string description): base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddPhoneValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
