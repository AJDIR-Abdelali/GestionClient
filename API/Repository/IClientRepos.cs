using API.Entities;

namespace API.Repository
{
    public interface IClientRepos
    {
        int Ajouter(Client entity);
        bool Delete(int id);
        Client Get(int id);
        List<Client> GetAll();
        bool Update(Client entity);

    }
}
