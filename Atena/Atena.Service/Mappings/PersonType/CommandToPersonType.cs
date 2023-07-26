using Atena.Domain.Commands.People.PersonType;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class CommandToPersonType : Profile
    {
        public CommandToPersonType() {

            CreateMap<AddPersonTypeCommand, PersonType>();

            CreateMap <UpdatePersonTypeCommand,PersonType>();

            CreateMap<RemovePersonTypeCommand, PersonType>();
        }
    }
}
