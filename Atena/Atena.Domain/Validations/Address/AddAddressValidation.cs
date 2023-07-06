using Atena.Domain.Commands.Address;

namespace Atena.Domain.Validations.Address
{
    public class AddAddressValidation : AddressValidation<AddAddressCommand>
    {
        public AddAddressValidation() 
        {
            Validate();
        }
    }
}
