namespace CiudadInteligenteObligatorio.Models
{
    public class Estadisticas
    {
        public List<Dato> ReportesBarrio { get; set; } = new();
        public List<Dato> ReportesCategoria { get; set; } = new();
        public List<Dato> ReportesEstado { get; set; } = new();
        public List<Dato> PromedioDiasCat { get; set; } = new();
        public int Pendientes { get; set; }
        public int EnProceso { get; set; }
        public int Resueltos { get; set; }
        public int RecursosOcupados { get; set; }
        public int ObrasActivas { get; set; }
    }

    public class Dato
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}