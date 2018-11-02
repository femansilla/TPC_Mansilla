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
        public int ProveedorTypeCode { get; set; }
        [DisplayName("Tipo")]
        public string ProveedorTypeDescripcion { get; set; }

        [DisplayName("Email")]
        public List<string> email { get; set; }
    }

    public class ProveedorVM
    {
        public int Code { get; set; }
        public string Descripcion { get; set; }
    }
}
