using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Address.AddressType
{
    public class UpdateAddressTypeCommand : AddressTypeCommand, IUpdateCommand
    {
        public UpdateAddressTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) 
        {
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAddresTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
