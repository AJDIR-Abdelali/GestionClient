using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table(name:"T_Client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Adresse { get; set; }
        public double Solde { get; set; }
        public DateTime? DataCreation { get; set; }

    }
}
