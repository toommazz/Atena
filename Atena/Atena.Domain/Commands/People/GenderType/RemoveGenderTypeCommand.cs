using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.GenderType;

namespace Atena.Domain.Commands.People.GenderType
{
    public class RemoveGenderTypeCommand : GenderTypeCommand, IRemoveCommand
    {
        public RemoveGenderTypeCommand(Guid? id) : base (id) 
        { 
            Id= id;
            Status = "0"; //Excluido
        
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveGenderTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
