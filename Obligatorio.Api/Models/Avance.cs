namespace Obligatorio.Api.Models
{
    public class Avance : Registro
    {
        public int ReporteId { get; set; }
        public string Tipo { get; set; } = "Avance";
        public string Descripcion { get; set; } = string.Empty;
        public string Dificultades { get; set; } = string.Empty;
        public string RecursosUsados { get; set; } = string.Empty;
        public int? AvanceAnteriorId { get; set; }
        public List<Foto> Fotos { get; set; } = new();
    }
}
