using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Company;

namespace Atena.Domain.Commands.Company
{
    public class UpdateCompanyCommand : CompanyCommand, IUpdateCommand
    {
        public UpdateCompanyCommand(
            Guid? id,
            string companyName,
            string corporateName,
            string cnpj) : base(id, companyName, corporateName, cnpj)
        {
            Id= id;

            CompanyName = companyName;

            CorporateName = corporateName;

            Cnpj = cnpj;
        }
        public Guid? Id { get; set; }
        public string CompanyName { get; set; }

        public string CorporateName { get; set; }

        public string Cnpj { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UpdateCompanyValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
