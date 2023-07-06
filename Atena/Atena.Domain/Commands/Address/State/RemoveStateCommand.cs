using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.State;

namespace Atena.Domain.Commands.Address.State
{
    public class RemoveStateCommand : StateCommand, IRemoveCommand
    {
        public RemoveStateCommand(Guid? id) : base(id) 
        {
            Id= id;
            Status = "0";//Excluido
        
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveStateValidation().Validate(this);

            return ValidationResult.IsValid;
        }

    }
}
