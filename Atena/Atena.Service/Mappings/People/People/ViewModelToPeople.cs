using Atena.Domain.Commands.People;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class ViewModelToPeople : Profile
    {
        public ViewModelToPeople()
        {
            CreateMap<PeopleViewModel, AddPeopleCommand>();

            CreateMap<PeopleViewModel, UpdatePeopleCommand>();

            CreateMap<PeopleViewModel, RemovePeopleCommand>();
        }
    }
}
