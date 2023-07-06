using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Client;

namespace Atena.Domain.Commands.People.Client
{
    public class AddClientCommand : ClientCommand, IAddCommand
    {
        public AddClientCommand(
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
            ) : base(id, name, cpf, rg, userName, genderTypeId, maritalStatusId, birthDate, dateFirstAccess, personTypeId) { }

        public override bool IsValid()
        {
            ValidationResult = new AddClientValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
