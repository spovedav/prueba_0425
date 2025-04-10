using CORE.CORs;
using CORE.Interfaces.Respositorio;
using CORE.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRespositorio _repo;

        public ProductoService(IProductoRespositorio repo)
        {
            this._repo = repo;           
        }

        public IQueryable<ProductoSPResult> GetAll() => _repo.GetAll(); 
    }
}
