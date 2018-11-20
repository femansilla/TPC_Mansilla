using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ProductoServices
    {
        private readonly DESA _data = new DESA();

        public List<SP_Get_All_Productos_Result> GetAllProductos()
        {
            return _data.SP_Get_All_Productos().ToList();
        }

        public SP_Get_Producto_byID_Result getProductoByID(int IdProducto)
        {
            return _data.SP_Get_Producto_byID(IdProducto).FirstOrDefault();
        }

        public void InsertProducto(string Descripcion)
        {
            var code = _data.SP_Insert_Producto(Descripcion, 1, 2);
        }

        public void DeleteProducto(int id)
        {
            _data.SP_Delete_Producto(id);
        }

        public void ActualizarProducto(string Descripcion, int idProducto)
        {
            _data.SP_update_Descripcion_Producto(Descripcion, idProducto);
        }

        public List<SP_Get_All_CategoriasProducts_Result> GetAllCategorias()
        {
            return _data.SP_Get_All_CategoriasProducts().ToList();
        }

        public List<SP_Get_Catalogo_ByProveedor_Result> GetCatalogoByProveedor(int provCode)
        {
            return _data.SP_Get_Catalogo_ByProveedor(provCode).ToList();
        }

        public List<ProveedorType> GetAllTypes()
        {
            List<ProveedorType> retlist = new List<ProveedorType>();
            foreach (var i in _data.SP_Get_All_ProductsTypes().ToList())
                retlist.Add(new ProveedorType() { Code = i.Code, Descripcion = i.Descripcion });
            return retlist;
        }

        public int GetStockByProduct(int iDProducto)
        {
            return (int)_data.SP_Get_StockDisponible_ByProduct(iDProducto).FirstOrDefault();
        }

        public decimal GetPrecioPrd(int iDProducto)
        {
            var a = _data.SP_Get_Price_ByProduct(iDProducto).FirstOrDefault();
            return decimal.Round((decimal)a, 2, MidpointRounding.AwayFromZero); ;
        }

        public string GetDescripcionTipoProductoByProducto(int iDProducto)
        {
            return _data.SP_Get_DescripcionType_ByProduct(iDProducto).FirstOrDefault();
        }

        public void SaveType(ProveedorType type)
        {
            if (type.Code != 0)
                _data.SP_Update_ProductType(type.Code, type.Descripcion);
            else
                _data.SP_Insert_ProductType(type.Descripcion);
        }

        public void EliminarProductType(int code)
        {
            _data.SP_Delete_ProductType(code);
        }

        public byte[] GetImagenProducto(int code)
        {
            return _data.SP_Get_Imagen_ByProducto(code).FirstOrDefault();
        }
    }
}
