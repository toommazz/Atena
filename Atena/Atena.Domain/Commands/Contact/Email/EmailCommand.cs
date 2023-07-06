using Atena.Domain.Core;
using System.Data;

namespace Atena.Domain.Commands.Contact.Email
{
    public class EmailCommand : Command
    {
        public EmailCommand(Guid? id) : base(id){ }

        public EmailCommand(
            Guid? id,
            string name,
            string description,
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
