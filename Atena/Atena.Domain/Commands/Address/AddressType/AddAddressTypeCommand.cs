using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.AddressType;

namespace Atena.Domain.Commands.Address.AddressType
{
    public class AddAddressTypeCommand : AddressTypeCommand, IAddCommand
    {
        public AddAddressTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }
        public override bool IsValid()
        {
            ValidationResult = new AddAddressTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
