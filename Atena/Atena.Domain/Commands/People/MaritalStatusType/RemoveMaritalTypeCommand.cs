using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.MaritalType;

namespace Atena.Domain.Commands.People.MaritalType
{
    public class RemoveMaritalStatusTypeCommand : MaritalStatusTypeCommand, IRemoveCommand
    {
        public RemoveMaritalStatusTypeCommand(Guid? id) : base(id)
        {
            Id= id;
            Status = "0"; //Excluido 
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveMaritalStatusTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
