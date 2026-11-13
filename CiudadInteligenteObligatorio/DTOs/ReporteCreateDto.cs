using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.DTOs
{
    public class ReporteCreateDto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Elige una categoría")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Elige el tipo de problema")]
        public string TipoProblema { get; set; } = "";

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "La descripción debe tener entre 10 y 1000 caracteres")]
        public string Descripcion { get; set; } = "";

        [Required(ErrorMessage = "La dirección es obligatoria")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string Direccion { get; set; } = "";

        [Required(ErrorMessage = "Elige un barrio")]
        public string Barrio { get; set; } = "";

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Razon { get; set; } = "";
    }
}