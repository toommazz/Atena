using Atena.Domain.Commands.People;

namespace Atena.Domain.Validations.People
{
    public class UpdatePeopleValidation : PeopleValidation<UpdatePeopleCommand>
    {
        public UpdatePeopleValidation()
        {
            ValidateId();
            Validate();
        }
    }
}
