using Atena.Domain.Commands.Company;

namespace Atena.Domain.Validations.Company
{
    public class RemoveCompanyValidation : CompanyValidation<RemoveCompanyCommand>
    {
        public RemoveCompanyValidation() 
        {
            Validate();
        }
    }
}
