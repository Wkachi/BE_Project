using ContactUsBEProject;

namespace ContactUsAPI.Controllers
{
    public class ContactUsRepository : Repository<ContactUs>
    {
        public ContactUsRepository(SessionFactory sessionFactory) : base(sessionFactory)
        {
        }
    }
}
//public class CustomerRepository : Repository<Customer>
//{
//    public CustomerRepository(SessionFactory sessionFactory) : base(sessionFactory)
//    {
//    }