using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.AddressType;

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
            ValidationResult = new UpdateAddressTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
