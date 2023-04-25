using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.DataObjectModel.ContactDto;
using CelilCavus.Energym.Models.DataObjectModel.Mapping.ContactMapping;
using CelilCavus.Energym.Models.UnitOfWorks;
using System.Web.Mvc;

namespace CelilCavus.Energym.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly UnitOfWork work;
        private readonly ContactMapping mapping;
        public ContactUsController()
        {
            this.work = new UnitOfWork(new Models.Database.Contexts.EmergymContext());
            this.mapping = new ContactMapping();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactUsInsertDto contactUs)
        {
            var contact = mapping.ContactUsInsertDto(contactUs);
            work.GetRepository<ContactUs>().Add(contact);
            work.SaveChanges();
            return View();
        }
    }
}