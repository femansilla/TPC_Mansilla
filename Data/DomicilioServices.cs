using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DomicilioServices
    {
        private static DESA _data = new DESA();

        public List<SP_Get_All_Provincias_Result> GetAllProvincias()
        {
            return _data.SP_Get_All_Provincias().ToList();
        }
    }
}
