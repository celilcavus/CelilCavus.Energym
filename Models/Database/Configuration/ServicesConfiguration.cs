using CelilCavus.Energym.Models.Database.Entitys;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.Energym.Models.Database.Configuration
{
    public class ServicesConfiguration : EntityTypeConfiguration<Services>
    {
        public ServicesConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ServiesTitle).IsRequired();
            Property(x => x.ServiesTitle).HasMaxLength(100);

            Property(x => x.ServiesImage).IsRequired();
            Property(x => x.ServiesImage).HasMaxLength(100);
        }
    }
}