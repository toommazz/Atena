using Atena.Domain.Commands.Company;

namespace Atena.Domain.Validations.Company
{
    public class UpdateCompanyValidation : CompanyValidation<UpdateCompanyCommand>
    {
        public UpdateCompanyValidation() 
        {
            ValidateId();
            Validate();
        }
    }
}
