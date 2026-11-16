namespace Obligatorio.Api.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
