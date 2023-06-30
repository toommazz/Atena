using Atena.Domain.Interfaces.Commands;
using System.Globalization;

namespace Atena.Domain.Commands.Company
{
    public class AddCompanyCommand : CompanyCommand, IAddCommand
    {
        public AddCompanyCommand(
            Guid? id, 
            string companyName, 
            string corporateName,
            string cnpj ) : base(id, companyName, corporateName, cnpj)
        {
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
