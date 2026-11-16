namespace Obligatorio.Api.Models
{
    public class AsignacionEmpleado : Asignacion
    {
        public int EmpleadoId { get; set; }
        public Usuario? Empleado { get; set; }
        public bool EsLider { get; set; }
    }
}
