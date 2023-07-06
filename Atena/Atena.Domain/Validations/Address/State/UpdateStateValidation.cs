
using Atena.Domain.Commands.Address.State;

namespace Atena.Domain.Validations.Address.State
{
    public class UpdateStateValidation : StateValidation<UpdateStateCommand>
    {
        public UpdateStateValidation()
        {
            ValidateId();
            Validate();
        
        }
    }
}
