
using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.State;

namespace Atena.Domain.Commands.Address.State
{
    public class AddStateCommand : StateCommand, IAddCommand
    {
        public AddStateCommand(
            Guid? id,
            string name,
            string description): base(id, name, description) { }

        public override bool IsValid()
        {
            ValidationResult = new AddStateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
