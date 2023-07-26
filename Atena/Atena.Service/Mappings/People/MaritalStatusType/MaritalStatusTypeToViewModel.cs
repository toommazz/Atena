using Atena.Domain.Core.Data;
using Atena.Domain.Model;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class MaritalStatusTypeToViewModel : Profile
    {
        public MaritalStatusTypeToViewModel()
        {
            CreateMap<MaritalStatusType, MaritalStatusTypeViewModel>();

            CreateMap<PagedList<MaritalStatusType>, PagedList<MaritalStatusTypeViewModel>>();
        }
    }
}
