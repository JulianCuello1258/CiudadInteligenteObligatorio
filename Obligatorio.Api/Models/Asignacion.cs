namespace Obligatorio.Api.Models
{
    public class Asignacion
    {
        public int Id { get; set; }
        public int ReporteId { get; set; }
        public DateTime FechaAsign { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Activa { get; set; } = true;
    }
}