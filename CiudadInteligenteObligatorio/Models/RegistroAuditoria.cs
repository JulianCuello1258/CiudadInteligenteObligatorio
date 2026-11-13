namespace CiudadInteligenteObligatorio.Models
{
    public class RegistroAuditoria : Registro
    {
        public string TipoRegistro { get; set; }
        public int RegistroId { get; set; }
        public string Accion { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
    }
}