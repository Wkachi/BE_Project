﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactUsDb.Mappings
{
    public class ContactUsMap: ClassMap<ContactUs>
    {
        public ContactUsMap()
        {

            Map(cont => cont.FirstName);
            Map(cont => cont.LastName);
            Map(cont => cont.Email);
            Map(cont => cont.PhoneNumber);
            Map(cont => cont.Message);
        }

    }
}
