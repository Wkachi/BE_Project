
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactUsCore;

namespace ContactUsDb.Repositories;

public class ContactUsRepository : Repository<ContactUs>
{
    public ContactUsRepository(SessionFactory sessionFactory) : base(sessionFactory)
    {

    }

    public object GetAll()
    {
        throw new NotImplementedException();
    }
}

