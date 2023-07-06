
using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Address.City
{
    public class AddCityCommand : CityCommand, IAddCommand
    {
        public AddCityCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }
        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
