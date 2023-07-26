using Atena.Service.Mappings.People.PersonType;
using AutoMapper;

namespace Atena.Service.Mappings
{
    public class MappingsConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelMappingProfile());
                config.AddProfile(new ViewModelToCommandMappingProfile());
                config.AddProfile(new CommandToDomainMappingProfile());
                config.AddProfile(new GenderTypeToViewModel());
                config.AddProfile(new ViewModelToGenderType());
                config.AddProfile(new CommandToGendeType());
                config.AddProfile(new PersonTypeToViewModel());
                config.AddProfile(new ViewModelToPersonType());
                config.AddProfile(new CommandToPersonType());
                config.AddProfile(new MaritalStatusTypeToViewModel());
                config.AddProfile(new ViewModelToMaritalStatusType());
                config.AddProfile(new CommandToMaritalStatusType());
            });
        }
    }
}
