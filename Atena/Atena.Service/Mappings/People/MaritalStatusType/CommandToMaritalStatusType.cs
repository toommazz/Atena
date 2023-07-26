using Atena.Domain.Commands.People.GenderType;
using Atena.Domain.Commands.People.MaritalType;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class CommandToMaritalStatusType : Profile
    {
        public CommandToMaritalStatusType()
        {
            CreateMap<AddMaritalStatusTypeCommand, MaritalStatusType>();

            CreateMap<AddMaritalStatusTypeCommand, MaritalStatusType>();
            
            CreateMap<AddMaritalStatusTypeCommand, MaritalStatusType>();
        }
    }
}
