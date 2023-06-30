using Atena.Domain.Core.Model;
using Atena.Domain.Model.Contact;
using Atena.Domain.Model.Address;

namespace Atena.Domain.Model
{
    public class Company : Entity
    {

        public Company(Guid? id) : base(id)
        {
            this.Address = new List<Address>();
            this.Email = new List<Email>();
            this.Phone = new List<Phone>();
        }
        public string CompanyName { get; set; }
        public string CorporateName { get; set; }
        public string CNPJ { get; set; }
        public string StateInscription { get; set; }
        public string CityInscription { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public List<Address> Address { get; set; }
        public List<Email> Email { get; set; }
        public List<Phone> Phone { get; set; }
    }
}
