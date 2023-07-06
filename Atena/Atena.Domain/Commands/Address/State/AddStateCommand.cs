
using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Address.State
{
    public class AddStateCommand : StateCommand, IAddCommand
    {
        public AddStateCommand(
            Guid? id,
            string name,
            string description): base(id, name, description) { }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
