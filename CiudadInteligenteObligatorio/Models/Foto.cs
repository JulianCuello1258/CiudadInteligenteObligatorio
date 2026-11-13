using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Foto : Registro
    {
        public string Url { get; set; }
        [Range(-90, 90, ErrorMessage = "Latitud no válida")]
        public double? Latitud { get; set; }
        [Range(-180, 180, ErrorMessage = "Longitud no válida")]
        public double? Longitud { get; set; }
        public bool Verificada { get; set; }
        public int? ReporteId { get; set; }
        public int? AvanceId { get; set; }
    }
}