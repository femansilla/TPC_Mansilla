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
        public int IDProducto { get; set; }
        [DisplayName("Nombre de producto")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public int ProductType { get; set; }
        public int Categoria { get; set; }

    }
}
