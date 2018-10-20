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

        public void AgregarProveedor(Proveedor prov)
        {
            _proveedorServices.InsertProveedor("");
        }
        public void EditarProducto(string descripcion, int id)
        {
            _proveedorServices.ActualizarProveedor(descripcion, id);
        }
        public void EliminarProducto(int id)
        {
            _proveedorServices.DeleteProveedor(id);
        }

        public List<ProveedorType> GetAllTypes()
        {
            List<ProveedorType> retList = new List<ProveedorType>();
            foreach(var type in _proveedorServices.GetAllTypes())
                retList.Add(new ProveedorType() { Code = type.Code, Descripcion = type.Descripcion });
            return retList;
        }

        public Proveedor GetProveedor(int id)
        {
            var prd = _proveedorServices.getProveedorByID(id);
            return new Proveedor()
            /*{
            //    IDProducto = (int)prd.Id,
            //    Descripcion = prd.Descripcion,
            //    ProductType = prd.ProductType,
            //    Categoria = prd.Categoria
            }*/;
        }

        public void SaveType(ProveedorType type)
        {
            _proveedorServices.SaveType(type);
        }

        public List<Proveedor> GetProveedores()
        {
            var alga = _proveedorServices.GetAllProveedores();
            List<Proveedor> ret = new List<Proveedor>();
            foreach (var prd in alga)
            {
                Proveedor prdRet = new Proveedor()
                /*{
                //    IDProducto = (int)prd.Id,
                //    Descripcion = prd.Descripcion,
                //    ProductType = prd.ProductType,
                //    Categoria = prd.Categoria
                }*/;
                ret.Add(prdRet);
            }
            return ret;
        }

        public void EliminarType(int code)
        {
            throw new NotImplementedException();
        }

        public List<Proveedor> GetAllProveedores()
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(int iD)
        {
            throw new NotImplementedException();
        }
    }
}
