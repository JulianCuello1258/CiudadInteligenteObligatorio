namespace Obligatorio.Api.Models
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public DateOnly FechaInicio { get; set; }
        public DateOnly FinEstimado { get; set; }
        public string Responsable  { get; set; } = string.Empty;
        public string Estado { get; set; } = "Planificada";
        public List<Reporte> Reportes { get; set; } = new();
    }
}