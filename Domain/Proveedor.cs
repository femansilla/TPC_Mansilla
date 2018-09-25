using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Proveedor : Persona
    {
        [DisplayName("Codigo")]
        public int ID { get; set; }

        [DisplayName("Tipo")]
        public int ProveedorType { get; set; }

        public List<Direccion> Direccion { get; set; }
    }
}
