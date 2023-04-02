namespace RiosDesierto_Front.Data
{
    public class UsuarioGetDTO
    {
        public int TipoDocumentoID { get; set; }
        public int NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public TipoDocumentoDTO TipoDocumento { get; set; }

    }
    public class TipoDocumentoDTO
    {
        public int TipoDocumentoID { get; set; }
        public string Descripcion { get; set; }
    }
}