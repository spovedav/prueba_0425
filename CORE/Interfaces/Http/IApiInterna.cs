using CORE.CORs;

namespace CORE.Interfaces.Http
{
    public interface IApiInterna
    {
        (List<ProductoSPResult>? lista, string? mensaje) GetAll();
    }
}
