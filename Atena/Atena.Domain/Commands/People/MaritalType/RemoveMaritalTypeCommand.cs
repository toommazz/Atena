using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.MaritalType;

namespace Atena.Domain.Commands.People.MaritalType
{
    public class RemoveMaritalTypeCommand : MaritalTypeCommand, IRemoveCommand
    {
        public RemoveMaritalTypeCommand(Guid? id) : base(id)
        {
            Id= id;
            Status = "0"; //Excluido 
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveMaritalTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
