using Atena.Domain.Model;
using Atena.Infra.Contexts.Config;
using Atena.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Atena.Infra.Contexts.Base
{
    public class AtenaDataContext : DbContext, IAtenaDbContext
    {
        public AtenaDataContext(DbContextOptions<AtenaDataContext> opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        }

        public DbSet<Company> Company { get; set; }
    }
}
