using Atena.Domain.Commands.People.GenderType;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class CommandToGendeType : Profile
    {
        public CommandToGendeType()
        {
            CreateMap<AddGenderTypeCommand, GenderType>();

            CreateMap<AddGenderTypeCommand, GenderType>();
            
            CreateMap<AddGenderTypeCommand, GenderType>();
        }
    }
}
