using API.Dtos;

namespace API.Service
{
    public interface IClientService
    {
        int ajouter(ClientPutDto entity);
        bool Delete(int id);
        ClientGetDto Get(int id);
        List<ClientGetDto> GetAll();
        bool Update(ClientPostDto entity);
    }
}
