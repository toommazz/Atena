using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.GenderType;

namespace Atena.Domain.Commands.People.GenderType
{
    public class AddGenderTypeCommand : GenderTypeCommand, IAddCommand
    {
        public AddGenderTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddGenderTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
