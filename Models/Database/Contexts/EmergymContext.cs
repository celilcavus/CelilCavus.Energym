using CelilCavus.Energym.Models.Database.Configuration;
using CelilCavus.Energym.Models.Database.Entitys;
using System.Data.Entity;

namespace CelilCavus.Energym.Models.Database.Contexts
{
    public class EmergymContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Services> Servies { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AboutConfiguration());
            modelBuilder.Configurations.Add(new ServicesConfiguration());
            modelBuilder.Configurations.Add(new ContactUsConfiguration());

        }
    }
}