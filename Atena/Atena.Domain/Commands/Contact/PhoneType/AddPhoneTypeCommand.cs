using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.PhoneType;

namespace Atena.Domain.Commands.Contact.PhoneType
{
    public class AddPhoneTypeCommand : PhoneTypeCommand, IAddCommand
    {
        public AddPhoneTypeCommand(
            Guid? id, 
            string name, 
            string description) : base (id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddPhoneTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
