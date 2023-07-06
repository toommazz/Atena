using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.State;

namespace Atena.Domain.Commands.Address.State
{
    public class UpdateStateCommand : StateCommand, IUpdateCommand
    {
        public UpdateStateCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) 
        {
            Id= id;
            Name= name; 
            Description= description;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdateStateValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
