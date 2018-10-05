using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClienteServices
    {
        public void InsertCliente(string descripcion)
        {
            //_data.SP_Insert_Cliente(Descripcion, 1, 2);
            throw new NotImplementedException();
        }

        public void ActualizarCliente(string descripcion, int id)
        {
            //_data.SP_update_Descripcion_Cliente(Descripcion, idCliente);
            throw new NotImplementedException();
        }

        public void DeleteCliente(int id)
        {
            //_data.SP_Delete_Cliente(id);
            throw new NotImplementedException();
        }

        public object getClienteByID(int id)
        {
            //return _data.SP_Get_Cliente_byID(IdCliente).FirstOrDefault();
            throw new NotImplementedException();
        }

        public object GetAllCliente()
        {
            //return _data.SP_Get_All_Clientes().ToList();
            throw new NotImplementedException();
        }
    }
}
