using API.Entities;

namespace API.Repository
{
    public class ClientRepos
    {

        protected readonly MyDbContext _context;

        public ClientRepos(MyDbContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            var list = _context.Clients.ToList();    
            return list;
        }

        public Client Get(int id)
        {
            var client = new Client();
            return client;
        }

        public bool Update(Client entity)
        {
            return true;
        }

        public int Ajouter(Client client)
        {
            return 12;
        }

        public bool delete(int id) 
        {
            return true;
        }


    }
}
