using Atena.Domain.Core.Data;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class PeopleToViewModel : Profile
    {
        public PeopleToViewModel()
        {
            CreateMap<Domain.Model.People, PeopleViewModel>();

            CreateMap<PagedList<Domain.Model.People>, PagedList<PeopleViewModel>>();
        }
    }
}
