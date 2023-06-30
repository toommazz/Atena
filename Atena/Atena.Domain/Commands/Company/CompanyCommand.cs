using Atena.Domain.Core;

namespace Atena.Domain.Commands.Company
{
    public class CompanyCommand : Command
    {
        public CompanyCommand(Guid? id)
            : base(id) { }

        public CompanyCommand(
            Guid? id,
            string companyName,
            string corporateName,
            string cnpj,
            string status = "1",
            DateTime included = default,
            DateTime updated = default

            ) : base(id, status, included, updated)
        {
            CompanyName = companyName;

            CorporateName = corporateName;

            Cnpj = cnpj;
        }

        public string CompanyName { get; set; }

        public string CorporateName { get; set; }

        public string Cnpj { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
