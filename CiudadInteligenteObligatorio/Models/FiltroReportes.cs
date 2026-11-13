using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class FiltroReportes
    {
        public int? CategoriaId { get; set; }
        public string? Barrio { get; set; }
        public string? Estado { get; set; }
        [RegularExpression("^(Alta|Media|Baja)$", ErrorMessage = "Prioridad no válida")]
        public string? Prioridad { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        [RegularExpression("^(Fecha|Estado|Categoria)$", ErrorMessage = "Orden no válido")]
        public string OrdenarPor { get; set; } = "Fecha";
        public bool Descendente { get; set; } = true;
        public bool Propios { get; set; }
        public int Pagina { get; set; } = 1;
        public int Tamanio { get; set; } = 20;
    }
}