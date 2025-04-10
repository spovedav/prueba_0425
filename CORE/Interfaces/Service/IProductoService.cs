using CORE.CORs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.Service
{
    public interface IProductoService
    {
        IQueryable<ProductoSPResult> GetAll();
    }
}
