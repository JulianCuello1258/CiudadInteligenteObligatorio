namespace Obligatorio.Api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;
        public string Rol { get; set; } = "Ciudadano";
        public string Cargo { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
