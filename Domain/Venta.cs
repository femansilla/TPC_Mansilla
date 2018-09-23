using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venta : Operacion
    {
        public List<Producto> ProductosVenta { get; set; }
        public float Total { get; set; }
    }
}
