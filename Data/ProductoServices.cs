using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductoServices
    {
        private readonly DESA _data = new DESA();

        public List<SP_Get_All_Productos_Result> GETALLPRODUCTOS()
        {
            return _data.SP_Get_All_Productos().ToList();
        }

        public SP_Get_Producto_byID_Result getProductoByID(int IdProducto)
        {
            return _data.SP_Get_Producto_byID(IdProducto).FirstOrDefault();
        }

        public void InsertProducto(string Descripcion)
        {
            _data.SP_Insert_Producto(Descripcion, 1, 2);
        }

        public void DeleteProducto(int id)
        {
            _data.SP_Delete_Producto(id);
        }

        public void ActualizarProducto(string Descripcion, int idProducto)
        {
            _data.SP_update_Descripcion_Producto(Descripcion, idProducto);
        }

    }
}
