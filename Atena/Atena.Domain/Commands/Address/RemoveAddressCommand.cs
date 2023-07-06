using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address;

namespace Atena.Domain.Commands.Address
{
    public class RemoveAddressCommand : AddressCommand, IRemoveCommand
    {
        public RemoveAddressCommand(Guid? id) : base(id)
        {
            Id = id;
            Status = "0"; //Excluído
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveAddressValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
