using Atena.Domain.Commands.Address.City;
using Atena.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atena.Domain.Commands.People.MaritalType
{
    public class MaritalTypeCommand : Command
    {
        public MaritalTypeCommand(Guid? id) : base(id) { }

        public MaritalTypeCommand(Guid? id,
            string name,
            string description,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)

        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
