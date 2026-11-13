using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El tipo es obligatorio")]
        [RegularExpression("^(Vehículo|Herramienta|Maquinaria|Equipamiento|Material)$", ErrorMessage = "Tipo no válido")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "El estado es obligatorio")]
        [RegularExpression("^(Disponible|En uso|En mantenimiento|Inactivo)$", ErrorMessage = "Estado no válido")]
        public string Estado { get; set; } = "Disponible";
        public int? ReporteActualId { get; set; }
    }
}