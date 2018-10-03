using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class ClienteController
    {
        private readonly ClienteServices _clienteServices = new ClienteServices();

        public void AgregarProducto(Producto prd)
        {
            _clienteServices.InsertProducto(prd.Descripcion);
        }
        public void EditarProducto(string descripcion, int id)
        {
            _clienteServices.ActualizarProducto(descripcion, id);
        }
        public void EliminarProducto(int id)
        {
            _clienteServices.DeleteProducto(id);
        }
        public Producto GetProducto(int id)
        {
            var prd = _clienteServices.getProductoByID(id);
            return new Producto()
            {
                IDProducto = (int)prd.Id,
                Descripcion = prd.Descripcion,
                ProductType = prd.ProductType,
                Categoria = prd.Categoria
            };
        }
        public List<Producto> GetProductos()
        {
            var alga = _clienteServices.GetAllProductos();
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
