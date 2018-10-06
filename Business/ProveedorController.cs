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
    }
}
