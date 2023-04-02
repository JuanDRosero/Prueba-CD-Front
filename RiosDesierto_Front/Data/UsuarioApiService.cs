namespace RiosDesierto_Front.Data
{
    public class UsuarioApiService
    {
        private List<UsuarioGetDTO> lista = new()
        {
            new UsuarioGetDTO()
            {
                TipoDocumentoID=1,
                NumeroDocumento=123,
                Nombre="Juan david",
                Apellido="Rosero",
                Correo="jdrosero59@gmail.com",
                Telefono=12456789,
                TipoDocumento = new TipoDocumentoDTO
                {
                    TipoDocumentoID=1,
                    Descripcion="NIT"
                }
            },
            new UsuarioGetDTO{
                TipoDocumentoID=1,
                NumeroDocumento=456,
                Nombre="Juan Carlos",
                Apellido="Rosero",
                Correo="jdrosero@live.com",
                Telefono=99999999,
                TipoDocumento = new TipoDocumentoDTO
                {
                    TipoDocumentoID=1,
                    Descripcion="NIT"
                }
            },
            new UsuarioGetDTO()
            {
                TipoDocumentoID=2,
                NumeroDocumento=123,
                Nombre="Paula A",
                Apellido="Rosero",
                Correo="PPP@gmail.com",
                Telefono=8888888,
                TipoDocumento = new TipoDocumentoDTO
                {
                    TipoDocumentoID=2,
                    Descripcion="Cedula"
                }
            }
        };


        public Task<UsuarioGetDTO?> SerachAsync(UsuarioSearchDTO Dto)
        {
            return Task.FromResult(lista.FirstOrDefault(x=>x.NumeroDocumento==Dto.NumeroDocumento &&
                                        x.TipoDocumentoID==Dto.TipoDocumentoID));
        }
    }
}