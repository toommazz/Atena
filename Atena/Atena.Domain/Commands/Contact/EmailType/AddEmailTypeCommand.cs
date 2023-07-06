using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.EmailType;

namespace Atena.Domain.Commands.Contact.EmailType
{
    public class AddEmailTypeCommand : EmailTypeCommand, IAddCommand
    {
        public AddEmailTypeCommand(
            Guid? id, 
            string name, 
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddEmailTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
