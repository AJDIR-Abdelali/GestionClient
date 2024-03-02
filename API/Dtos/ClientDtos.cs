namespace API.Dtos
{
    public record ClientGetDto(int id ,string nom , string adresse , double solde );
    public record ClientPostDto(string nom,string adresse);
    public record ClientPutDto(int id, string nom, string adresse, double solde);
}
