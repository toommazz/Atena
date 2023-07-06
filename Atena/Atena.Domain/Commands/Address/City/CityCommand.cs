using Atena.Domain.Core;

namespace Atena.Domain.Commands.Address.City
{
    public class CityCommand : Command
    {
        public CityCommand(Guid? id) : base(id) { }    

        public CityCommand(
            Guid? id,
            string name,
            string  description,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)
        {
            Name=name;
            Description=description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
