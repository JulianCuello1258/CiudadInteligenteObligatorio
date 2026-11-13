namespace CiudadInteligenteObligatorio.Models
{
    public class PaginaResultado<T>
    {
        public int Pagina { get; set; }
        public int Tamanio { get; set; }
        public int Total { get; set; }
        public List<T> RepXPagina { get; set; } = new();
        public int TotalPaginas => Tamanio == 0 ? 0 : (int)Math.Ceiling(Total / (double)Tamanio);
    }
}