using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Usuario : Persona
    {
        [DisplayName("Codigo")]
        public int IDUser { get; set; }
        [DisplayName("Id usuario")]
        public string UserName { get; set; }
        public string Password { get; set; }

        [DisplayName("Tipo")]
        public int UserType { get; set; }
    }
}
