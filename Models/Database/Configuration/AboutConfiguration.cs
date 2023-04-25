using CelilCavus.Energym.Models.Database.Entitys;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.Energym.Models.Database.Configuration
{
    public class AboutConfiguration : EntityTypeConfiguration<About>
    {
        public AboutConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.AboutTitle).IsRequired();
            Property(x => x.AboutTitle).HasMaxLength(50);

            Property(x => x.AboutIcon).IsRequired();
            Property(x => x.AboutIcon).HasMaxLength(100);

            Property(x => x.AboutDescription).IsRequired();
            Property(x => x.AboutDescription).IsMaxLength();
        }
    }
}