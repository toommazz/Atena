using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Company
{
    public class RemoveCompanyCommand : CompanyCommand, IRemoveCommand
    {
        public RemoveCompanyCommand(Guid? id) : base(id)
        {
            Id = id;
            Status = "0"; //Excluído
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveCompanyValidation().Validate(this);
            return ValidationResult.IsValid;
        }
}
