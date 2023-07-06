using Atena.Domain.Core;
using Atena.Domain.Model;

namespace Atena.Domain.Commands.People.Client
{
    public class ClientCommand : Command
    {
        public ClientCommand(Guid? id) : base(id) { }

        public ClientCommand(
            Guid? id,
            string name,
            string cpf,
            string rg,
            string userName,
            Guid genderTypeId,
            Guid maritalStatusId,
            DateTime birthDate,
            DateTime dateFirstAccess,
            Guid personTypeId,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)
        {
            Name = name;
            CPF = cpf;
            RG = rg;
            Username = userName;
            GenderTypeId = genderTypeId;
            MaritalStatusId = maritalStatusId;
            BirthDate = birthDate;
            DateFirstAccess = dateFirstAccess;
            PersonTypeId = personTypeId;

        }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Username { get; set; }
        public Guid? GenderTypeId { get; set; }
        public Guid? MaritalStatusId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DateFirstAccess { get; set; }
        public Guid? PersonTypeId { get; set; }
        public string Status { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
