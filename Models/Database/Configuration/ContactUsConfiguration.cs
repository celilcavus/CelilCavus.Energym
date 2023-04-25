using CelilCavus.Energym.Models.Database.Entitys;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.Energym.Models.Database.Configuration
{
    public class ContactUsConfiguration : EntityTypeConfiguration<ContactUs>
    {
        public ContactUsConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).IsRequired();
            Property(x => x.Name).HasMaxLength(50);

            Property(x => x.Email).IsRequired();
            Property(x => x.Email).HasMaxLength(50);

            Property(x => x.PhonenNumber).IsRequired();
            Property(x => x.PhonenNumber).HasMaxLength(11);

            Property(x => x.Message).IsRequired();
            Property(x => x.Message).HasMaxLength(500);

        }
    }
}