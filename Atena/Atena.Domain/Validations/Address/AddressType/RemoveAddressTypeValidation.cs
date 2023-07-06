using Atena.Domain.Commands.Address.AddressType;

namespace Atena.Domain.Validations.Address.AddressType
{
    public class RemoveAddressTypeValidation : AddressTypeValidation<RemoveAddressTypeCommand>
    {
        public RemoveAddressTypeValidation() 
        {
            ValidateeId();
        }
    }
}
