using Atena.Domain.Commands.People;

namespace Atena.Domain.Validations.People
{
    public class RemovePeopleValidation : PeopleValidation<RemovePeopleCommand>
    {
        public RemovePeopleValidation() 
        {
            ValidateId();
        }
    }
}
