namespace Obligatorio.Api.Models
{
    public class Foto : Registro
    {
        public string Url { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public double? Longitud { get; set; }
        public double? Latitud { get; set; }
        public bool Verificada { get; set; }
        public int? ReporteId { get; set; }
        public int? AvanceId { get; set; }
    }
}
