using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.Energym.Models.DataObjectModel.ContactDto
{
    public class ContactUsInsertDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhonenNumber { get; set; }
        public string Message { get; set; }
    }
}