using ContactUsDb;

namespace ContactUsAPI.Controllers
{
    public class Repository<T>
    {
        private SessionFactory sessionFactory;

        public Repository(SessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }
    }
}