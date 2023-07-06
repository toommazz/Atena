﻿using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.PersonType;

namespace Atena.Domain.Commands.People.PersonType
{
    public class UpdatePersonTypeCommand : PersonTypeCommand, IUpdateCommand
    {   
        public UpdatePersonTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePersonTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
