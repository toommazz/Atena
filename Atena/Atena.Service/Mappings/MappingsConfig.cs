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
            });
        }
    }
}
