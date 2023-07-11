using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.Client;

namespace Atena.Domain.Commands.People.Client
{
    public class RemoveClientCommand : ClientCommand, IRemoveCommand
    {
        public RemoveClientCommand(Guid? id) : base(id)
        {
            Id = id;
            Status = "0"; //Excluído
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveClientValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
