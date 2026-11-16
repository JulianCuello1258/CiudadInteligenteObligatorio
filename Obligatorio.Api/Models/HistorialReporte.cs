namespace Obligatorio.Api.Models
{
    public class HistorialReporte : Registro
    {
        public int ReporteId { get; set; }
        public string Tipo { get; set; }
        public string EstadoAnterior { get; set; } = string.Empty;
        public string EstadoNuevo { get; set; } = string.Empty;
        public string Desctipcion { get; set; } = string.Empty;
    }
}
