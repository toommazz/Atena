using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class Address : Entity
    {
        public Address(Guid? id) : base(id)
        {
        }
        public Guid? AddressTypeId { get; set; }
        public string AddressName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public Guid? CityId { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Reference { get; set; }
        public virtual Client ClientId { get; set; }

    }
    
   
}
