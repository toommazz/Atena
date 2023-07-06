using Atena.Domain.Commands.People.Client;

namespace Atena.Domain.Validations.People.Client
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
