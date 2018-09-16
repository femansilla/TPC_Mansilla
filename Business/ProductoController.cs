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
        ProductoServices _productoServices = new ProductoServices();
        //La teoria dice que aca tengo que instanciar un obj de mi clase
        //ProductoServices para usar los metodos que conectan a la base... pero no me esta saliendo
        //Ya se que no es la metodologia que planteaste, pero me llevo mejor con esta...
        //y en la ventana de la vista, tengo ganas de al insertar, voy a insertar la descripcion, y ademas quiero guardar
        //una imagen, que me recomendas que copie la imagen a una carpeta especifa de la app
        //y que me lleve path a la base?
        public void AgregarProducto(Producto prd)
        {
            _productoServices.InsertProducto(prd.Descripcion);
            //insert de un producto.
        }
        public void EditarProducto()
        {
            //update de un producto
        }
        public void EliminarProducto()
        {
            //eliminar un producto
        }
        public void GetProducto()
        {
            //traer un producto
        }
        public List<Producto> GetProductos()
        {
            //aca quiero traerme la lista de todos los productos
            var alga = _productoServices.GETALLPRODUCTOS();
            List<Producto> ret = new List<Producto>();
            foreach (var prd in alga)
            {
                Producto prdRet = new Producto() {
                    Descripcion = prd.Descripcion
                };
                ret.Add(prdRet);
            }
            return ret;
        }
    }
}
