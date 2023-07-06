using Atena.Domain.Commands.Address.AddressType;

namespace Atena.Domain.Validations.Address.AddressType
{
    public class UpdateAddressTypeValidation : AddressTypeValidation<UpdateAddressTypeCommand>
    {
        public UpdateAddressTypeValidation()
        {
            ValidateeId();
            Validate();
        }
    }
}
