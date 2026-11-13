using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class HistorialReporte : Registro
    {
        public int ReporteId { get; set; }
        [Required(ErrorMessage = "El tipo es obligatorio")]
        [RegularExpression("^(Cambio de estado|Respuesta|Asignación)$", ErrorMessage = "Tipo no válido")]
        public string Tipo { get; set; }
        public string EstadoAnterior { get; set; }
        public string EstadoNuevo { get; set; }
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Descripcion { get; set; }
    }
}
