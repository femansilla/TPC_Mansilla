using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class ProductoController
    {
        private readonly ProductoServices _productoServices = new ProductoServices();

        public void AgregarProducto(Producto prd)
        {
            _productoServices.InsertProducto(prd.Descripcion);
        }
        public void EditarProducto(string descripcion, int id)
        {
            _productoServices.ActualizarProducto(descripcion, id);
        }
        public void EliminarProducto(int id)
        {
            _productoServices.DeleteProducto(id);
        }
        public Producto GetProducto(int id)
        {
            var prd = _productoServices.getProductoByID(id);
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
            var alga = _productoServices.GetAllProductos();
            List<Producto> ret = new List<Producto>();
            foreach (var prd in alga)
            {
                Producto prdRet = new Producto() {
                    IDProducto = (int)prd.Id,
                    Descripcion = prd.Descripcion,
                    ProductType = prd.ProductType,
                    Categoria = prd.Categoria
                };
                ret.Add(prdRet);
            }
            return ret;
        }

        public List<CategoriasProductos> GetAllCategorias()
        {
            var list = _productoServices.GetAllCategorias();
            List<CategoriasProductos> retList = new List<CategoriasProductos>();
            foreach (var item in list)
            {
                retList.Add(new CategoriasProductos()
                            {
                                Code = item.Code,
                                Descripcion = item.Descripcion
                            });
            }
            return retList;
        }
    }
}
