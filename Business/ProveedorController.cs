using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class ProveedorController
    {
        private readonly ProveedorServices _proveedorServices = new ProveedorServices();

        public List<Proveedor> GetAllProveedores()
        {
            var listProv = _proveedorServices.GetAllProveedores();
            List<Proveedor> retList = new List<Proveedor>();
            foreach (var p in listProv)
            {
                retList.Add(new Proveedor()
                {
                    ID = p.Code,
                    Apellido = p.Apellido,
                    Nombre = p.Nombre,
                    FechaNac = p.FechaNac,
                    Sex = (p.Sexo == "M") ? true : false,
                    SexDescription = (p.Sexo == "M") ? "Masculino" : "Femenino",
                    CUIT = p.CUIT,
                    ProveedorTypeCode = (int)p.TypeCode,
                    ProveedorTypeDescripcion = p.ProveedorType
                });
            }
            return retList;
        }

        public Proveedor GetProveedor(int id)
        {
            var p = _proveedorServices.GetProveedorByID(id);
            return new Proveedor()
            {
                ID = p.Code,
                Apellido = p.Apellido,
                Nombre = p.Nombre,
                FechaNac = p.FechaNac,
                Sex = (p.Sexo == "M") ? true : false,
                SexDescription = (p.Sexo == "M") ? "Masculino" : "Femenino",
                CUIT = p.CUIT,
                ProveedorTypeCode = (int)p.TypeCode,
                ProveedorTypeDescripcion = p.ProveedorType
            };
        }
        
        public void GuardarProveedor(Proveedor prov)
        {
            _proveedorServices.SaveProveedor(prov);
        }

        public void EliminarProveedor(int id)
        {
            _proveedorServices.EliminarProveedor(id);
        }

        
        /// <summary>
        /// 
        /// </summary>
        public void EliminarType(int code)
        {
            _proveedorServices.EliminarProveedorType(code);
        }
        
        public List<ProveedorType> GetAllTypes()
        {
            List<ProveedorType> retList = new List<ProveedorType>();
            foreach (var type in _proveedorServices.GetAllTypes())
                retList.Add(new ProveedorType() { Code = type.Code, Descripcion = type.Descripcion });
            return retList;
        }

        public void SaveType(ProveedorType type)
        {
            _proveedorServices.SaveType(type);
        }



    }
}
