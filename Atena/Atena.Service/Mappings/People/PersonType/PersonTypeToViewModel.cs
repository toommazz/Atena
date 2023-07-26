using Atena.Domain.Core.Data;
using Atena.Domain.Model;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class PersonTypeToViewModel : Profile
    {
        public PersonTypeToViewModel()
        {
            CreateMap<PersonType, PersonTypeViewModel>();

            CreateMap<PagedList<PersonType>, PagedList<PersonTypeViewModel>>();
        }
    }
}
