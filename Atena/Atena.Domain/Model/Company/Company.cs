using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class Company : Entity
    {
        public Company(Guid? id) : base(id) { }
        public string CompanyName { get; set; }
        public string CorporateName { get; set; }
        public string CNPJ { get; set; }
    }
}
