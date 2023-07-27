using Atena.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atena.Infra.Contexts.Config
{
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("TbPeople");
              //  .HasMany("GenderType")
            //    .WithMany("People");
                
            builder.HasKey(x => x.Id);

            builder.Property(s => s.Id)
                .IsRequired();
        }
    }
}
