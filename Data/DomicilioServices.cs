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

        public List<SP_Get_Localidad_Result> GetLocalidad(int selectedValue)
        {
            return _data.SP_Get_Localidad(selectedValue).ToList();
        }

        public List<SP_Get_Calle_Result> GetCalle(int selectedValue)
        {
            return _data.SP_Get_Calle(selectedValue).ToList();
        }

        public IEnumerable<SP_Get_Domicilio_Usuario_byUserID_Result> GetDomiciliosUser(int propietarioCode)
        {
            return _data.SP_Get_Domicilio_Usuario_byUserID(propietarioCode).ToList();
        }

        public IEnumerable<SP_Get_Domicilio_Proveedor_byProveedorID_Result> GetDomiciliosProveedor(int propietarioCode)
        {
            return _data.SP_Get_Domicilio_Proveedor_byProveedorID(propietarioCode).ToList();
        }

        public IEnumerable<SP_Get_Domicilio_Cliente_byClienteID_Result> GetDomiciliosCliente(int propietarioCode)
        {
            return _data.SP_Get_Domicilio_Cliente_byClienteID(propietarioCode).ToList();
        }


    }
}
