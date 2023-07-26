using Atena.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atena.Infra.Contexts.Config
{
    public class GenderTypeConfiguration : IEntityTypeConfiguration<GenderType>
    {
        public void Configure(EntityTypeBuilder<GenderType> builder)
        {
            builder.ToTable("TbGenderType");

            builder.HasKey(x => x.Id);

            builder.Property(s => s.Id)
                .IsRequired();
        }
    }
}
