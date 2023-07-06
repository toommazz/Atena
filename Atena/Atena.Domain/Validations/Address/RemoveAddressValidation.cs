using Atena.Domain.Commands.Address;

namespace Atena.Domain.Validations.Address
{
    public class RemoveAddressValidation : AddressValidation<RemoveAddressCommand>
    {
        public RemoveAddressValidation()
        {
            ValidateId();
        }
    }
}
