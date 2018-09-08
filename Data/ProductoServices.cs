using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class ProductoServices
    {
        private static DESA _data;
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
            _data.SP_Insert_Producto(Descripcion);
        }

    }
}
