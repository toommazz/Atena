using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Phone;

namespace Atena.Domain.Commands.Contact.Phone
{
    public class RemovePhoneCommand : PhoneCommand, IRemoveCommand
    {
        public RemovePhoneCommand(Guid? id) : base(id) 
        {
            Id= id;
            Status = "0"; //Excluido
        }

        public override bool IsValid()
        {
            ValidationResult = new RemovePhoneValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
