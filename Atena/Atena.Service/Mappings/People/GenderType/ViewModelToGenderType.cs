using Atena.Domain.Commands.Company;
using Atena.Domain.Commands.People.GenderType;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class ViewModelToGenderType : Profile
    {
        public ViewModelToGenderType()
        {
            CreateMap<GenderTypeViewModel, AddGenderTypeCommand>();

            CreateMap<GenderTypeViewModel, UpdateGenderTypeCommand>();

            CreateMap<GenderTypeViewModel, RemoveGenderTypeCommand>();
        }
    }
}
