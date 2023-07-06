
using Atena.Domain.Commands.Address.AddressType;

namespace Atena.Domain.Validations.Address.AddressType
{
    public class AddAddressTypeValidation : AddressTypeValidation<AddAddressTypeCommand>
    {
        public AddAddressTypeValidation() 
        {
            Validate();
        }
    }
}
