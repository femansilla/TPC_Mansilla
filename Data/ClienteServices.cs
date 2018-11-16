using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ClienteServices
    {
        private static DESA _data = new DESA();
        
        public void SaveCliente(Cliente clt)
        {
            if(clt.ID != 0)
            {
                var retCode = _data.SP_Update_Cliente(clt.ID, clt.Nombre, clt.Apellido, clt.SexDescription, clt.CUIT, clt.FechaNac);
                _data.SP_Update_PriceList_ByClient(clt.ClientType, clt.ID);
                foreach (var direc in clt.DomicilioUser)
                {
                    direc.ID = (int)_data.SP_Insert_Direccion(direc.Provincia, direc.Localidad, direc.Calle, direc.Altura).FirstOrDefault();
                    _data.SP_Insert_Direccion_Cliente(clt.ID, direc.ID);
                }

            }
            else
            {
                var insertCode = _data.SP_Insert_Cliente(clt.Nombre, clt.Apellido, clt.SexDescription, clt.CUIT, clt.FechaNac).FirstOrDefault();
                _data.SP_Insert_PriceList_ByClient(clt.ClientType, insertCode);
                foreach (var direc in clt.DomicilioUser)
                {
                    direc.ID = (int)_data.SP_Insert_Direccion(direc.Provincia, direc.Localidad, direc.Calle, direc.Altura).FirstOrDefault();
                    _data.SP_Insert_Direccion_Proveedor(clt.ID, direc.ID);
                }
            }
        }

        public int GetPriceListByClient(int code)
        {
            var alga = _data.SP_Get_PriceList_ByClient(code).FirstOrDefault();
            return (int)alga;
        }

        public void DeleteCliente(int id)
        {
            _data.SP_Delete_Cliente(id);
        }

        public SP_Get_Cliente_ByID_Result getClienteByID(int id)
        {
            return _data.SP_Get_Cliente_ByID(id).FirstOrDefault();
        }

        public string GetPriceDescriptionListByClient(int code)
        {
            return _data.SP_Get_PriceListDescription_ByClient(code).FirstOrDefault();
        }

        public List<SP_Get_All_Clientes_Result> GetAllClientes()
        {
            return _data.SP_Get_All_Clientes().ToList();
        }

        public IEnumerable<SP_Get_All_PriceList_Result> GetAllPriceList()
        {
            return _data.SP_Get_All_PriceList().ToList();
        }
    }
}
