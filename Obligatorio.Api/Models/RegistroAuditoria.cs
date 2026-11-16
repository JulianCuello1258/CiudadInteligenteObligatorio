namespace Obligatorio.Api.Models
{
    public class RegistroAuditoria : Registro
    {
        public string Cosa { get; set; } = string.Empty;
        public int CosaId { get; set; }
        public string Accion { get; set; } = string.Empty;
        public string ValorNuevo { get; set; } = string.Empty;
    }
}
