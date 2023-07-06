using Atena.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XAct;

namespace Atena.Infra.Contexts.Config
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("TbCompany");

            builder.HasKey(x => x.Id);

            builder.Property(s => s.Id)
                .IsRequired();
        }
    }
}
