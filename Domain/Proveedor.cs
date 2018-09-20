using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Proveedor
    {
        [DisplayName("Codigo")]
        public int ID { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [DisplayName("CUIT")]
        public string CUIT { get; set; }

        [DisplayName("Tipo")]
        public int ProveedorType { get; set; }
    }
}
