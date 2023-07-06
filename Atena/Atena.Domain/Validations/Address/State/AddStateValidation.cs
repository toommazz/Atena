using Atena.Domain.Commands.Address.State;

namespace Atena.Domain.Validations.Address.State
{
    public class AddStateValidation : StateValidation<AddStateCommand>
    {
        public AddStateValidation() 
        {
            Validate();
        }
    }
}
