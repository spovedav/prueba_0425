using CORE.CORs;
using CORE.Interfaces.Respositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRE.Repositorio
{
    public class ProductoRespositorio : IProductoRespositorio
    {
        private readonly MiBase _context;

        public ProductoRespositorio(MiBase contex)
        {
            _context = contex;
        }

        public IQueryable<ProductoSPResult> GetAll() => _context.EjecutarObtenerProductoSP();
    }
}
