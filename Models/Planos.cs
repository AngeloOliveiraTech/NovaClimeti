using System.ComponentModel.DataAnnotations.Schema;

namespace NovaClimeti.Models
{
    public class Planos
    {
        public int Id { get; set; } 
        public string Titulo { get; set; }
        [Column(TypeName="TEXT")]
        public string Descricao { get; set; }
    }
}
