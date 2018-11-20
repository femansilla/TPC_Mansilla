using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Operacion
    {
        public int CodigoOperacion { get; set; }
        public string TipoOperacion { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Usuario")]
        public string UsuarioRealizoAccion { get; set; }
    }
}