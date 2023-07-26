using Atena.Domain.Core.Data;
using Atena.Domain.Model;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class GenderTypeToViewModel : Profile
    {
        public GenderTypeToViewModel()
        {
            CreateMap<GenderType, GenderTypeViewModel>();

            CreateMap<PagedList<GenderType>, PagedList<GenderTypeViewModel>>();
        }
    }
}
