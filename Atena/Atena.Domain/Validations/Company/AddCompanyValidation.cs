using Atena.Domain.Commands.Company;

namespace Atena.Domain.Validations.Company
{
    public class AddCompanyValidation : CompanyValidation<AddCompanyCommand>
    {
        public AddCompanyValidation()
        {
            Validate();
        }
    }
}
