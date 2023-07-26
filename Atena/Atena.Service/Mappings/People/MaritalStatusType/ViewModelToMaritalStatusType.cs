using Atena.Domain.Commands.People.MaritalType;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class ViewModelToMaritalStatusType : Profile
    {
        public ViewModelToMaritalStatusType()
        {
            CreateMap<MaritalStatusTypeViewModel, AddMaritalStatusTypeCommand>();

            CreateMap<MaritalStatusTypeViewModel, UpdateMaritalStatusTypeCommand>();

            CreateMap<MaritalStatusTypeViewModel, RemoveMaritalStatusTypeCommand>();
        }
    }
}
