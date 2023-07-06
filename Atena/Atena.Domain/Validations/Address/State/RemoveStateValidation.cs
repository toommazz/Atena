
using Atena.Domain.Commands.Address.State;

namespace Atena.Domain.Validations.Address.State
{
    public class RemoveStateValidation : StateValidation<RemoveStateCommand>
    {
        public RemoveStateValidation() 
        {
            ValidateId();
        }
    }
}
