using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ClientRepos : IClientRepos
    {

        protected readonly MyDbContext _context;

        public ClientRepos(MyDbContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client Get(int id)
        {
            return _context.Clients.Find(id);
        }

        public bool Update(Client entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public int Ajouter(Client entity)
        {
            //return 12;
            _context.Clients.Add(entity);
            _context.SaveChanges();
            return entity.Id; // Assuming Id is the primary key
        }


        public bool Delete(int id)
        {
            var client = _context.Clients.Find(id);
            if (client == null)
                return false;

            _context.Clients.Remove(client);
            _context.SaveChanges();
            return true;
        }
    }
}
