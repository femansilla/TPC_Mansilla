using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Persona
    {
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [DisplayName("CUIT/ CUIL")]
        public string CUIT { get; set; }

        public bool Sex { get; set; }
        [DisplayName("Sexo")]
        public string SexDescription { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNac { get; set; }

        public List<Direccion> DomicilioUser { get; set; }
    }
}
