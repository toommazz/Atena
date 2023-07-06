using Atena.Domain.Commands.Company;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class ViewModelToCommandMappingProfile : Profile
    {
        public ViewModelToCommandMappingProfile()
        {
            CreateMap<CompanyViewModel, AddCompanyCommand>();

            CreateMap<CompanyViewModel, UpdateCompanyCommand>();

            CreateMap<CompanyViewModel, RemoveCompanyCommand>();
        }
    }
}
