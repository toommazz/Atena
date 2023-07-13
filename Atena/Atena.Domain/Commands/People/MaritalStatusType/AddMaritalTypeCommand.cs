using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.MaritalType;


namespace Atena.Domain.Commands.People.MaritalType
{
    public class AddMaritalStatusTypeCommand : MaritalStatusTypeCommand, IAddCommand
    {
        public AddMaritalStatusTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddMaritalStatusTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
