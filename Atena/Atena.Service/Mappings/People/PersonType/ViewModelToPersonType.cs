using Atena.Domain.Commands.People.PersonType;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings.People.PersonType
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
