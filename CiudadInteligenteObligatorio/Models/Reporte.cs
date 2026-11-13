namespace CiudadInteligenteObligatorio.Models
{
    public class Reporte
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; } = "";
        public string TipoProblema { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Barrio { get; set; } = "";
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Razon { get; set; } = "";
        public string Prioridad { get; set; } = "";
        public string Estado { get; set; } = "";
        public bool Reabierto { get; set; }
        public string MotivoRechazo { get; set; } = "";
        public bool? ResultadoEsperado { get; set; }
        public int? ReportePrincipalId { get; set; }
        public int? ObraId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaSolucion { get; set; }
        public List<Foto> Fotos { get; set; } = new();
        public List<HistorialReporte> Historial { get; set; } = new();
        public List<AsignacionEmpleado> Empleados { get; set; } = new();
        public List<AsignacionRecurso> Recursos { get; set; } = new();
    }
}