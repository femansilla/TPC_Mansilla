using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Compra : Operacion
    {
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [DisplayName("CUIT/ CUIL")]
        public string CUIT { get; set; }
        public string Referencia { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public List<ProductoOperacion> ProductosCompra { get; set; }
        public int ProveedorCode { get; set; }
        public int EstadoCode { get; set; }
    }
}
