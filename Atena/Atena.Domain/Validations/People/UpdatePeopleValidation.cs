using Atena.Domain.Commands.People;

namespace Atena.Domain.Validations.People
{
    public class UpdatePeopleValidation : PeopleValidation<UptadePeopleCommand>
    {
        public UpdatePeopleValidation()
        {
            ValidateId();
            Validate();
        }
    }
}
