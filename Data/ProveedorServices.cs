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
        
        public List<SP_Get_All_Proveedores_Result> GetAllProveedores()
        {
            return _data.SP_Get_All_Proveedores().ToList();
        }

        public void SaveProveedor(Proveedor prv)
        {
            if (prv.ID != 0)
            {
                _data.SP_Update_Proveedor(prv.ID, prv.Nombre, prv.Apellido, prv.SexDescription, prv.FechaNac, prv.CUIT);
                _data.SP_Update_TipoProveedor(prv.ID, prv.ProveedorTypeCode);

            }
            else
            {
                var insertCode = _data.SP_Insert_Proveedor(prv.Nombre, prv.Apellido, prv.SexDescription, prv.FechaNac, prv.CUIT).FirstOrDefault();
                _data.SP_Insert_TipoProveedor(insertCode, prv.ProveedorTypeCode);

            }
        }

        public SP_Get_Proveedor_ByID_Result GetProveedorByID(int id)
        {
            return _data.SP_Get_Proveedor_ByID(id).FirstOrDefault();
        }

        public void EliminarProveedor(int iD)
        {
            _data.SP_Delete_Proveedor(iD);
        }

        public IList<SP_Get_All_ProveedorTypes_Result> GetAllTypes()
        {
            return _data.SP_Get_All_ProveedorTypes().ToList();
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

        public void EliminarProveedorType(int id)
        {
            _data.SP_Delete_ProveedorType(id);
        }
    }
}
