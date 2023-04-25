using CelilCavus.Energym.Models.Database.Entitys;

namespace CelilCavus.Energym.Models.DataObjectModel.AboutDto
{
    public class AboutListDto : BaseEntity
    {
        public string AboutTitle { get; set; }
        public string AboutIcon { get; set; }
        public string AboutDescription { get; set; }
    }
}