using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class DomicilioController
    {
        private DomicilioServices _direccionServices = new DomicilioServices();

        public List<Provincia> GetAllProvincias()
        {
            List<Provincia> retList = new List<Provincia>();
            foreach (var item in _direccionServices.GetAllProvincias())
                retList.Add(new Provincia() { Code = item.Code, Descripcion = item.Descripcion });
            return retList;
        }
    }
}
