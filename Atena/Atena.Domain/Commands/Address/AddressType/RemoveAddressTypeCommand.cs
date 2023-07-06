using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Address.AddressType
{
    public class RemoveAddressTypeCommand : AddressTypeCommand, IRemoveCommand
    {
        public RemoveAddressTypeCommand(Guid? id) : base(id)
        {
            Id = id;
            Status = "0"; //Excluído
        }

        public override bool IsValid()
        {
            //ValidationResult = new RemoveAddressTypeValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}
