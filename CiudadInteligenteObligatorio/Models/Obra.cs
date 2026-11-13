using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Obra
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La ubicación es obligatoria")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string Ubicacion { get; set; }
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "La fecha estimada de finalización es obligatoria")]
        public DateTime FinEstimado { get; set; }
        [Required(ErrorMessage = "El estado es obligatorio")]
        [RegularExpression("^(Planificada|En ejecución|Finalizada)$", ErrorMessage = "Estado no válido")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "El responsable es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string DepResponsable { get; set; }
        public List<Reporte> Reportes { get; set; } = new();
    }
}