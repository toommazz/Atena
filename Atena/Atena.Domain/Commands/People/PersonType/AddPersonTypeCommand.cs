using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.PersonType;

namespace Atena.Domain.Commands.People.PersonType
{
    public class AddPersonTypeCommand : PersonTypeCommand, IAddCommand
    {
        public AddPersonTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddPersonTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
