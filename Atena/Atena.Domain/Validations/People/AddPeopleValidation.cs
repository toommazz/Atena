using Atena.Domain.Commands.People;
using Atena.Domain.Validations.People;

namespace Atena.Domain.Validations
{
    public class AddPeopleValidation : PeopleValidation<AddPeopleCommand>
    {
        public AddPeopleValidation() 
        {
            Validate();
        }
    }
}
