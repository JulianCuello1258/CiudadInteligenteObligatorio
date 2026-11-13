using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Avance : Registro
    {
        [Range(1, int.MaxValue, ErrorMessage = "Debe indicar el reporte")]
        public int ReporteId { get; set; }
        [Required(ErrorMessage = "El tipo es obligatorio")]
        [RegularExpression("^(Avance|Informe)$", ErrorMessage = "El tipo debe ser Avance o Informe")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Describe el trabajo realizado")]
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "La descripción debe tener entre 5 y 2000 caracteres")]
        public string Descripcion { get; set; }
        [StringLength(2000, ErrorMessage = "Máximo 2000 caracteres")]
        public string Dificultades { get; set; }
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string RecursosUsados { get; set; }
        public int? AvanceAnteriorId { get; set; }
        public List<Foto> Fotos { get; set; } = new();
    }
}