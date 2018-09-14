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
        [DisplayName("Nombre de producto")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}
