using Atena.Domain.Commands.People.Client;

namespace Atena.Domain.Validations.People.Client
{
    public class RemoveClientValidation : ClientValidation<RemoveClientCommand>
    {
        public RemoveClientValidation()
        {
            ValidateId();
        }
    }
}
