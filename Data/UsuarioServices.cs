using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioServices
    {
        private static DESA _data = new DESA();
        public bool ExistUser(string user, string password)
        {
            var val = _data.SP_validateUser(user, password).FirstOrDefault();
            return (!string.IsNullOrEmpty(val)) ? bool.Parse(_data.SP_validateUser(user, password).FirstOrDefault()) : false;
        }
    }
}
