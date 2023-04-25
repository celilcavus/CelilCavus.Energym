using CelilCavus.Energym.Models.Database.Contexts;
using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.DataObjectModel.AboutDto;
using CelilCavus.Energym.Models.UnitOfWorks;
using System.Linq;

namespace CelilCavus.Energym.Models.DataObjectModel.Mapping.AboutMapping
{
    public class AboutMap
    {
        private readonly UnitOfWork _work;

        public AboutMap()
        {
            _work = new UnitOfWork(new EmergymContext());
        }

        public IQueryable<AboutListDto> GetAboutList()
        {
            var x = from i in _work.GetRepository<About>().GetListAsc()
                    select new AboutListDto
                    {
                        AboutTitle = i.AboutTitle,
                        AboutIcon = i.AboutIcon,
                        AboutDescription = i.AboutDescription
                    };
            return x.AsQueryable();
        }
        public IQueryable<About> GetAboutListReverseMap()
        {
            var x = from i in _work.GetRepository<AboutListDto>().GetListAsc()
                    select new About
                    {
                        AboutTitle = i.AboutTitle,
                        AboutIcon = i.AboutIcon,
                        AboutDescription = i.AboutDescription
                    };
            return x.AsQueryable();
        }
    }
}