using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.PhoneType;

namespace Atena.Domain.Commands.Contact.PhoneType
{
    public class RemovePhoneTypeCommand : PhoneTypeCommand, IRemoveCommand
    {
        public RemovePhoneTypeCommand(Guid? id) : base (id) 
        {
            Id=id;
            Status = "0"; //Excluido
        }
        public override bool IsValid()
        {
            ValidationResult = new RemovePhoneTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }

}
