using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Asignacion
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe indicar el reporte")]
        public int ReporteId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Activo { get; set; }
    }
}
