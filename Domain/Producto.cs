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
        [DisplayName("Descripcion producto")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        [DisplayName("Tipo")]
        public int ProductType { get; set; }
        [DisplayName("Categoria")]
        public int Categoria { get; set; }

    }
}
