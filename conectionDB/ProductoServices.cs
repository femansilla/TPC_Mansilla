using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectionDB
{
    class ProductoServices
    {
        private static DESA bdata = new DESA();
        List<GetAllProductos_Result> getProductos()
        {
            return bdata.GetAllProductos().ToList();
        }
    }
}
