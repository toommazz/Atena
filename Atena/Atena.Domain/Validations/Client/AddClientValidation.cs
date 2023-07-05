using Atena.Domain.Commands.Client;

namespace Atena.Domain.Validations.Client
{
    public class AddClientValidation : ClientValidation<AddClientCommand>
    {
        public AddClientValidation()
        {
            Validate();
        }
    }
}
