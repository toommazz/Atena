using Atena.Domain.Core;

namespace Atena.Domain.Commands.Company
{
    public class CompanyCommand : Command
    {
        public CompanyCommand(Guid? id) : base (id) { }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
