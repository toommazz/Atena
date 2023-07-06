using Atena.Domain.Commands.Address;

namespace Atena.Domain.Validations.Address
{
    public class UpdateAddressValidation : AddressValidation<UpdateAddressCommand>
    {
        public UpdateAddressValidation() 
        {
            ValidateId();
            Validate();

        }
    }
}
