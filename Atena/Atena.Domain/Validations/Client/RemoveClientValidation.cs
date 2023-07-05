using Atena.Domain.Commands.Client;

namespace Atena.Domain.Validations.Client
{
    public class RemoveClientValidation : ClientValidation<RemoveClientCommand>
    {
        public RemoveClientValidation()
        {
            ValidateId();
        }
    }
}
