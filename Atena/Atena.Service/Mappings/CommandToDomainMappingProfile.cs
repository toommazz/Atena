using Atena.Domain.Commands.Company;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class CommandToDomainMappingProfile : Profile
    {
        public CommandToDomainMappingProfile()
        {
            CreateMap<AddCompanyCommand, Company>();

            CreateMap<UpdateCompanyCommand, Company>();
            
            CreateMap<RemoveCompanyCommand, Company>();
        }
    }
}
