using Atena.Domain.Core.Data;
using Atena.Domain.Model;
using Atena.Service.ViewModels;

namespace Atena.Service.Mappings
{
    public class PersonTypeToViewModel
    {
        public PersonTypeToViewModel() 
        {
            CreateMap<PersonType, PersonTypeViewModel>();

            CreateMap<PagedList<PersonType>, PersonTypeViewModel>();

        }
    }
}
