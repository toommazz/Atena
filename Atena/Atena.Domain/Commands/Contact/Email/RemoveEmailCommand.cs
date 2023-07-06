using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Email;

namespace Atena.Domain.Commands.Contact.Email
{
    public class RemoveEmailCommand : EmailCommand, IRemoveCommand
    {
        public RemoveEmailCommand(Guid? id) : base (id) 
        {
            Id= id;
            Status = "0"; // Excluido
        
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveEmailValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
