using CelilCavus.Energym.Models.DataObjectModel.Mapping.ServiceMapping;
using CelilCavus.Energym.Models.DataObjectModel.ServiceDto;
using System.Linq;
using System.Web.Mvc;

namespace CelilCavus.Energym.Controllers
{
    public class ServiesController : Controller
    {
        ServiceMapping mapping;

        public ServiesController()
        {
            this.mapping = new ServiceMapping();
        }

        public ActionResult Index()
        {
            var mapList = mapping.GetServiceDtoListsAsc();
            if (mapList is null)
            {
                return View(Enumerable.Empty<ServiceDtoList>());
            }
            return View(mapList);
        }
    }
}