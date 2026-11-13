using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class AsignacionRecurso : Asignacion
    {
        [Range(1, int.MaxValue, ErrorMessage = "Elege un recurso")]
        public int RecursoId { get; set; }
        public string NombreRecurso { get; set; }
    }
}