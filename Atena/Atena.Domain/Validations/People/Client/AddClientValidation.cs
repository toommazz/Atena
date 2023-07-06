using Atena.Domain.Commands.People.Client;

namespace Atena.Domain.Validations.People.Client
{
    public class AddClientValidation : ClientValidation<AddClientCommand>
    {
        public AddClientValidation()
        {
            Validate();
        }
    }
}
