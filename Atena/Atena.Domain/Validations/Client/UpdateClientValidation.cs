using Atena.Domain.Commands.Client;

namespace Atena.Domain.Validations.Client
{
    public class UpdateClientValidation : ClientValidation<UpdateClientCommand>
    {
        public UpdateClientValidation()
        {
            ValidateId();
            Validate();
        }
    }
}
