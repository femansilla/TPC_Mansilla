using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Stock
    {
        public int ProcuctCode { get; set; }
        public int CantProductoEnStock { get; set; }
        public int CantProductTotVendido { get; set; }
        public int CantProductUltimaVenta { get; set; }
        public int CantProductUltimaCompra { get; set; }
    }
}
