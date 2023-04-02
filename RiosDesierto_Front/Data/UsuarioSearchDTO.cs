using System.ComponentModel.DataAnnotations;

namespace RiosDesierto_Front.Data
{
    public record UsuarioSearchDTO
    {
        [Required(ErrorMessage ="EL Tipo de Documento es requerido")]
        public int TipoDocumentoID { get; set; }
        [Required(ErrorMessage ="EL Numero de documento es requerido")]
        public int NumeroDocumento { get; set; }
    }
}
