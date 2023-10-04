namespace NovaClimeti.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int VagaId { get; set; }
        public Vaga Vaga { get; set; }
        public string UploadArquivo { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
