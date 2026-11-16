namespace Obligatorio.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<TipoProblema> Tipos { get; set; } = new();
    }
}
