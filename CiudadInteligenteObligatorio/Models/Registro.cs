namespace CiudadInteligenteObligatorio.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
