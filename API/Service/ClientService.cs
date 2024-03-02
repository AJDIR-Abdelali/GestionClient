using API.Dtos;
using API.Entities;
using API.Repository;

namespace API.Service
{
    public class ClientService
    {
        public ClientRepos _clientRepos;

        public ClientService(ClientRepos _clientRepos) {
            this._clientRepos = _clientRepos;
        }

        public List<ClientGetDto> GetAll()
        {
            var listOriginal = _clientRepos.GetAll();
            var list = new List<ClientGetDto>();
            return list;
        }

        public ClientGetDto Get(int id)
        {
            //var client = new ClientGetDto();
            //return client;
            var client = new ClientGetDto(12,"said","Casa",12);
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
