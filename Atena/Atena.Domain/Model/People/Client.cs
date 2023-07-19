using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class Client : Entity
    {
        public Client(Guid? id) : base(id) { }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Username { get; set; }
        public Guid? GenderTypeId { get; set; }
        public Guid? MaritalStatusTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DateFirstAccess { get; set; }
        public Guid? PersonTypeId { get; set; }


    }
}
