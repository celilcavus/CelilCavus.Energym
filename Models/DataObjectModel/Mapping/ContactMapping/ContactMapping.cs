using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.DataObjectModel.ContactDto;


namespace CelilCavus.Energym.Models.DataObjectModel.Mapping.ContactMapping
{
    public class ContactMapping
    {
       
        public ContactUs ContactUsInsertDto(ContactUsInsertDto contact)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Name = contact.Name;
            contactUs.Email = contact.Email;
            contactUs.PhonenNumber = contact.PhonenNumber;
            contactUs.Message = contact.Message;

            return contactUs;

        }
    }
}