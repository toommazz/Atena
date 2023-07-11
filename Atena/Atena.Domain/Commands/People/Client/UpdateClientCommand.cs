using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.Client;

namespace Atena.Domain.Commands.People.Client
{
    public class UpdateClientCommand : ClientCommand, IUpdateCommand
    {
        public UpdateClientCommand(
             Guid? id,
            string name,
            string cpf,
            string rg,
            string userName,
            Guid genderTypeId,
            Guid maritalStatusId,
            DateTime birthDate,
            DateTime dateFirstAccess,
            Guid personTypeId
            ) : base(id, name, cpf, rg, userName, genderTypeId, maritalStatusId, birthDate, dateFirstAccess, personTypeId)
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
        public override bool IsValid()
        {
            ValidationResult = new UpdateClientValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
