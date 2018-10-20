using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ProveedorServices
    {
        private static DESA _data = new DESA();
        
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

        public IList<SP_Get_All_ProveedorTypes_Result> GetAllTypes()
        {
            return _data.SP_Get_All_ProveedorTypes().ToList();
        }

        public void EliminarProveedorType(int id)
        {
            _data.SP_Delete_ProveedorType(id);
        }

        public object getProveedorByID(int id)
        {
            //return _data.SP_Get_Proveedor_byID(IdProveedor).FirstOrDefault();
            throw new NotImplementedException();
        }

        public List<SP_Get_All_Proveedores_Result> GetAllProveedores()
        {
            return _data.SP_Get_All_Proveedores().ToList();
        }

        public void SaveType(ProveedorType type)
        {
            if(type.Code != 0)
            {
                _data.SP_Update_ProveedorType(type.Code, type.Descripcion);
            }
            else
            {
                _data.SP_Insert_ProveedorType(type.Descripcion);
            }
        }
    }
}
