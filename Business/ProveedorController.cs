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

        public void AgregarProveedor(Producto prd)
        {
            _proveedorServices.InsertProveedor(prd.Descripcion);
        }
        public void EditarProducto(string descripcion, int id)
        {
            _proveedorServices.ActualizarProveedor(descripcion, id);
        }
        public void EliminarProducto(int id)
        {
            _proveedorServices.DeleteProveedor(id);
        }

        public Producto GetProveedor(int id)
        {
            var prd = _proveedorServices.getProveedorByID(id);
            return new Producto()
            {
                IDProducto = (int)prd.Id,
                Descripcion = prd.Descripcion,
                ProductType = prd.ProductType,
                Categoria = prd.Categoria
            };
        }
        public List<Producto> GetProveedores()
        {
            var alga = _proveedorServices.GetAllProveedores();
            List<Producto> ret = new List<Producto>();
            int i = 1;
            foreach (var prd in alga)
            {
                Producto prdRet = new Producto()
                {
                    IDProducto = (int)prd.Id,
                    Descripcion = prd.Descripcion,
                    ProductType = prd.ProductType,
                    Categoria = prd.Categoria
                };
                ret.Add(prdRet);
            }
            return ret;
        }
    }
}
