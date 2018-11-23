using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venta : Operacion
    {
        public float Total { get; set; }
        public int ClienteCode { get; set; }
        public string Referencia { get; set; }
        public int EstadoCode { get; set; }
        public string Estado { get; set; }
        public List<ProductoOperacion> ProductosVenta { get; set; }
    }
}
