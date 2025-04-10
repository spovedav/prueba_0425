using CORE.CORs;
using CORE.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;
        public ProductoController(IProductoService _service)
        {
            this._service = _service;
        }

        [HttpGet("Get-All")]
        public IQueryable<ProductoSPResult> GetAll() => _service.GetAll();
    }
}
