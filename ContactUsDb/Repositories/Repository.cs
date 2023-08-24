namespace ContactUsDb.Repositories
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