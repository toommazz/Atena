using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Email;

namespace Atena.Domain.Commands.Contact.Email
{
    public class AddEmailCommand : EmailCommand, IAddCommand
    {
        public AddEmailCommand(
            Guid? id,
            string name, 
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddEmailValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
