namespace API.Repository
{
    public class GeneriqueRepos<T> where T : class

    {
        public List<T> GetAll()
        {
            var list = new List<T>();
            return list;
        }

        //public T Get(int id)
        //{
        //    //T obj;
        //    //return obj;
        //}

        public bool Update(T entity)
        {
            return true;
        }
        public int Ajouter(T entity)
        {
            return 12;
        }

        public bool Delete(int id)
        {
            return true;
        }

    }
}
