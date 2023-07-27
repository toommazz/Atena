using Atena.Domain.Commands.People;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class CommandToPeople : Profile
    {
        public CommandToPeople()
        {

            CreateMap<AddPeopleCommand, Domain.Model.People>();

            CreateMap<UpdatePeopleCommand, Domain.Model.People>();

            CreateMap<RemovePeopleCommand, Domain.Model.People>();
        }
    }
}