using CelilCavus.Energym.Models.DataObjectModel.AboutDto;
using CelilCavus.Energym.Models.DataObjectModel.Mapping.AboutMapping;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CelilCavus.Energym.Controllers
{
    public class AboutController : Controller
    {
        AboutMap map;

        public AboutController()
        {
            this.map = new AboutMap();
        }

        public ActionResult Index()
        {
            var list = map.GetAboutList().LastOrDefault();
            if (list is null)
            {
               return View(Enumerable.Empty<List<AboutListDto>>());
            }
            return View(list);
        }
    }
}