using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProveedorServices
    {
        public void InsertProveedor(string descripcion)
        {
            //_data.SP_Insert_Proveedor(Descripcion, 1, 2);
            throw new NotImplementedException();
        }

        public void ActualizarProveedor(string descripcion, int id)
        {
            //_data.SP_update_Descripcion_Proveedor(Descripcion, idProveedor);
            throw new NotImplementedException();
        }

        public void DeleteProveedor(int id)
        {
            //_data.SP_Delete_Proveedor(id);
            throw new NotImplementedException();
        }

        public object getProveedorByID(int id)
        {
            //return _data.SP_Get_Proveedor_byID(IdProveedor).FirstOrDefault();
            throw new NotImplementedException();
        }

        public object GetAllProveedores()
        {
            //return _data.SP_Get_All_Proveedores().ToList();
            throw new NotImplementedException();
        }
    }
}
