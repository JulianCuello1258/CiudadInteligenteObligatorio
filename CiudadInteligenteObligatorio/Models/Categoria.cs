using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }
        public List<TipoProblema> Tipos { get; set; } = new();
    }
}