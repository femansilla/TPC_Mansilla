using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Compra : Operacion
    {
        public string Proveedor { get; set; }
        public string Referencia { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public List<ProductoOperacion> ProductosCompra { get; set; }
    }
}
