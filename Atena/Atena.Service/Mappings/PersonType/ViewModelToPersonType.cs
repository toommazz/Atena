using Atena.Domain.Commands.People.PersonType;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class ViewModelToPersonType : Profile
    {
        public ViewModelToPersonType() 
        {
            CreateMap<PersonTypeViewModel, AddPersonTypeCommand>();

            CreateMap<PersonTypeViewModel, UpdatePersonTypeCommand>();

            CreateMap<PersonTypeViewModel, RemovePersonTypeCommand>();
        }
    }
}
