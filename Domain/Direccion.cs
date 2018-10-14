using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Direccion
    {
        [DisplayName("Codigo")]
        public int ID { get; set; }

        [DisplayName("Provincia")]
        public string Provincia { get; set; }
        [DisplayName("Localidad")]
        public string Localidad { get; set; }
        [DisplayName("Calle")]
        public string Calle { get; set; }
        [DisplayName("Altura")]
        public int Altura { get; set; }

        [DisplayName("Piso")]
        public int Piso { get; set; }
        [DisplayName("Departamento")]
        public int Departamento { get; set; }
    }
}
