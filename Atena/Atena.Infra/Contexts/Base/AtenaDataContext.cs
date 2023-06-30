using Atena.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Atena.Infra.Contexts.Base
{
    public class AtenaDataContext : DbContext, IAtenaDbContext
    {
        public AtenaDataContext(DbContextOptions<AtenaDataContext> opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DemoConfiguration());
        }

        //public DbSet<Demo> Demos { get; set; }
    }
}
