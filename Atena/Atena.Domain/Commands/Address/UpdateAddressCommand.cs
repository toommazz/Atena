using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address;

namespace Atena.Domain.Commands.Address
{
    public class UpdateAddressCommand : AddressCommand, IUpdateCommand
    {
        public UpdateAddressCommand(
            Guid? id,
            Guid addressTypeId,
            string addressName,
            string number,
            string complement,
            string district,
            Guid cityId,
            Guid stateId,
            string zipCode,
            string reference,
            Guid clientId
                        
            ) : base(id, addressTypeId, addressName, number, complement, district, cityId, stateId, zipCode, reference, clientId)
        {
            AddressTypeId = addressTypeId;
            AddressName = addressName;
            Number = number;
            Complement = complement;
            District = district;
            CityId = cityId;
            StateId = stateId;
            ZipCode = zipCode;
            Reference = reference;
            ClientId = clientId;
        }
        public Guid? AddressTypeId { get; set; }
        public string AddressName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public Guid? CityId { get; set; }
        public Guid? StateId { get; set; }
        public string ZipCode { get; set; }
        public string Reference { get; set; }
        public Guid? ClientId { get; set; }
        public string Status { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAddressValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
