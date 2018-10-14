using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Localidad
    {
        public int Code { get; set; }
        [DisplayName("Localidad")]
        public string Descripcion { get; set; }
    }
}
