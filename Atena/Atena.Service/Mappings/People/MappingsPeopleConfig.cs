using AutoMapper;

namespace Atena.Service.Mappings
{
    public class MappingsPeopleConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new GenderTypeToViewModel());
                config.AddProfile(new ViewModelToGenderType());
                config.AddProfile(new CommandToGendeType());
                config.AddProfile(new MaritalStatusTypeToViewModel());
                config.AddProfile(new ViewModelToMaritalStatusType());
                config.AddProfile(new CommandToMaritalStatusType());
            });
        }
    }
}
