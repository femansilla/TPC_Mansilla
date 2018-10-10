using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Producto
    {
        [DisplayName("Codigo")]
        public int IDProducto { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        [DisplayName("Precio")]
        public float Precio { get; set; }
        [DisplayName("Tipo")]
        public string ProductType { get; set; }
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        public string Imagen { get; set; }
    }
}
