namespace Obligatorio.Api.Models
{
    public class TipoProblema
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}