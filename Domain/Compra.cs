using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Compra : Operacion
    {
        public List<Producto> ProductosCompra { get; set; }
        public float Total { get; set; }
    }
}
