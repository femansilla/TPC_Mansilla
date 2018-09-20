using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Usuario
    {
        public int IDUser { get; set; }
        public string UserNamer { get; set; }
        public string Password { get; set; }

        public int UserType { get; set; }
    }
}
