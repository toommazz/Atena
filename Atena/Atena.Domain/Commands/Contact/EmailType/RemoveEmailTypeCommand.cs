using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.EmailType;

namespace Atena.Domain.Commands.Contact.EmailType
{
    public  class RemoveEmailTypeCommand : EmailTypeCommand, IRemoveCommand
    {
        public RemoveEmailTypeCommand(Guid? id) : base (id)
        {
            Id= id;
            Status = "0"; //Excluido
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveEmailTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
