using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class TipoProblema
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Elege una categoría")]
        public int CategoriaId { get; set; }
    }
}