
using Atena.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atena.Infra.Contexts.Config
{
    public class PersonTypeConfiguration : IEntityTypeConfiguration<PersonType>
    {
        public void Configure(EntityTypeBuilder<PersonType> builder)
        {
            builder.ToTable("PersonType");

            builder.HasKey(x => x.Id);

            builder.Property(s => s.Id)
                .IsRequired();
        }
    }
}
