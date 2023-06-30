using Atena.Domain.Core;

namespace Atena.Domain.Commands.Client
{
    public  class ClientCommand : Command
    {
        public ClientCommand(Guid? id) : base (id) { }
        
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
