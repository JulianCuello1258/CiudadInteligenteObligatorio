namespace Obligatorio.Api.Models
{
    public class Reporte
    {

        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public string TipoProblema { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Barrio { get; set; } = string.Empty;
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Razon { get; set; } = string.Empty;
        public string Prioridad { get; set; } = string.Empty;
        public string Estado { get; set; } = "Reportado";
        public bool Reabierto { get; set; }
        public string MotivoRechazo { get; set; } = string.Empty;
        public bool? Resultado { get; set; }
       
        public int AutorId { get; set; }
        public Usuario? Autor { get; set; }
        public int? ReportePrincipalId { get; set; }
        public Reporte ReportePrincipal { get; set; }
        public int? ObraId { get; set; }
        public Obra? Obra { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime? FechaSolucion { get; set; }
        public List<Foto> Fotos { get; set; } = new();
        public List<HistorialReporte> Historial { get; set; } = new();
        public List<Avance> Avance { get; set; } = new();
        public List<AsignacionEmpleado> Empleados { get; set; } = new();
        public List<AsignacionRecurso> Recursos { get; set; } = new();
    }
}