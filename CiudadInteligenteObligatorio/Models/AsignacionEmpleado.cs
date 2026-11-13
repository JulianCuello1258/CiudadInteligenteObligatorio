using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class AsignacionEmpleado : Asignacion
    {
        [Range(1, int.MaxValue, ErrorMessage = "Elige un empleado")]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public bool Lider { get; set; }
    }
}
