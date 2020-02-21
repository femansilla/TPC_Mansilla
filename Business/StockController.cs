using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class StockController
    {
        private readonly ProductoServices _stockServices = new ProductoServices();

        public void AgregarProducto(Producto prd)
        {
            //_stockServices.InsertProducto(prd.Descripcion);
        }
        public void EditarStock(string descripcion, int id)
        {
            //_stockServices.ActualizarProducto(descripcion, id);
        }
        public void EliminarProducto(int id)
        {
            _stockServices.DeleteProducto(id);
        }
        public Producto GetProducto(int id)
        {
            var prd = _stockServices.getProductoByID(id);
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
            var alga = _stockServices.GetAllProductos();
            List<Producto> ret = new List<Producto>();
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
