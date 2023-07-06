using Atena.Domain.Core;

namespace Atena.Domain.Commands.Address
{
    public class AddressCommand : Command
    {
        public AddressCommand(Guid? id ): base(id) { }

        public AddressCommand(
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
            Guid clientId,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)
        {
            AddressTypeId = addressTypeId;
            AddressName = addressName;
            Number = number;
            Complement = complement;
            District= district;
            CityId = cityId;
            StateId = stateId;
            ZipCode= zipCode;
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
            throw new NotImplementedException();
        }
    }
}
