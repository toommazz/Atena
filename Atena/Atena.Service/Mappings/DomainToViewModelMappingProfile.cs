using Atena.Domain.Core.Data;
using Atena.Domain.Model;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Company, CompanyViewModel>();

            CreateMap<PagedList<Company>, PagedList<CompanyViewModel>>();

        }
    }
}
