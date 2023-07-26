using Atena.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atena.Infra.Contexts.Config
{
    public class MaritalStatusTypeConfiguration : IEntityTypeConfiguration<MaritalStatusType>
    {
        public void Configure(EntityTypeBuilder<MaritalStatusType> builder)
        {
            builder.ToTable("MaritalStatusType");

            builder.HasKey(x => x.Id);

            builder.Property(s => s.Id)
                .IsRequired();
        }
    }
}
