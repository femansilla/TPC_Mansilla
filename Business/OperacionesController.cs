using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class OperacionesController
    {
        private readonly OperacionesServices _operacionesServices = new OperacionesServices();

        public bool SaveCompra(Compra cmp)
        {
            _operacionesServices.SaveCompra(cmp);
            return true;
        }
    }
}
