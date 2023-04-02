namespace RiosDesierto_Front.Data
{
    public class TiposDocumentoAPIService
    {
        public async Task<IEnumerable<TipoDocumentoDTO>> GetAsync()
        {
            return await Task.FromResult(new List<TipoDocumentoDTO>()
            {
                new TipoDocumentoDTO()
                {
                    TipoDocumentoID=1,
                    Descripcion="NIT"
                },
               new TipoDocumentoDTO()
                {
                    TipoDocumentoID=2,
                    Descripcion="CC"
                },
               new TipoDocumentoDTO()
                {
                    TipoDocumentoID=3,
                    Descripcion="Pasporte"
                }
            });
        }
    }
}
