using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Client;

namespace Atena.Domain.Commands.Client
{
    public class UpdateClientCommand : ClientCommand, IUpdateCommand
    {
        public UpdateClientCommand(Guid? id, string name) : base(id)
        {
            Id = id;
            Name = name;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateClientValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
