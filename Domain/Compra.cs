using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Compra : Operacion
    {
        public List<ProductoOperacion> ProductosCompra { get; set; }
        public decimal Total { get; set; }
    }
}
