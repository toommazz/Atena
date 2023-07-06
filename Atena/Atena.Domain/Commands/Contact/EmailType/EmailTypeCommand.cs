﻿using Atena.Domain.Core;

namespace Atena.Domain.Commands.Contact.EmailType
{
    public class EmailTypeCommand : Command
    {
        public EmailTypeCommand(Guid? id) : base(id) { }
        public EmailTypeCommand(
            Guid? id,
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
