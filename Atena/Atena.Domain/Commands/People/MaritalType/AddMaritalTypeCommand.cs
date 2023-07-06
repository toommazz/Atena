using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.MaritalType;

namespace Atena.Domain.Commands.People.MaritalType
{
    public class AddMaritalTypeCommand : MaritalTypeCommand, IAddCommand
    {
        public AddMaritalTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddMaritalTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
