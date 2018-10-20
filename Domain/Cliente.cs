using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Cliente : Persona
    {
        [DisplayName("Codigo")]
        public int ID { get; set; }
        public int ClientType { get; set; }
        [DisplayName("Tipo")]
        public string ClientTypeDescripcion { get; set; }

        [DisplayName("Email")]
        public List<string> email { get; set; }
    }
}
