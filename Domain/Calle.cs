using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Calle
    {
        public int Code { get; set; }
        [DisplayName("Calle")]
        public string Descripcion { get; set; }
        [DisplayName("Altura")]
        public int Altura { get; set; }
    }
}
