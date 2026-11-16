namespace Obligatorio.Api.Models
{
    public class CodigoVerificacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public bool Usado { get; set; }
        public DateTime FechaExpiracion { get; set; }
    }
}