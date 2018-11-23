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

        public void SaveProducto(int code, string descripcion, int typeCode, string imagen)
        {
            if(code == 0){
                _productoServices.InsertProducto(descripcion, typeCode, imagen);
            }
            else
            {
                _productoServices.EditProducto(code, descripcion, typeCode, imagen);
            }
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
                Categoria = prd.Categoria,
                Imagen = _productoServices.GetImagenDescripcionProducto(prd.Id)
            };
        }

        public void CreateRelationProductoProveedor(int provCode, int productCode)
        {
            _productoServices.CreateRelationProductProveedor(productCode, provCode);
        }

        public void DeleteRelationProductoProveedor(int code, int provCode)
        {
            _productoServices.DeleteRelationProductoProveedor(code, provCode);
        }

        public object GetAllProductosView(int provCode)
        {
            var Catalogo = _productoServices.GetCatalogoByProveedor(provCode);
            List<ProductoDescripcion> retCatalog = new List<ProductoDescripcion>();
            foreach (var p in Catalogo)
            {
                retCatalog.Add(new ProductoDescripcion()
                {
                    Code = p.code,
                    Descripcion = p.Descripcion
                });
            }
            return retCatalog;
        }

        public int GetStockPrd(int iDProducto)
        {
            return _productoServices.GetStockByProduct(iDProducto);
        }

        public string GetDescripcionTipoProducto(int iDProducto)
        {
            return _productoServices.GetDescripcionTipoProductoByProducto(iDProducto);
        }

        public decimal GetPrecioPrd(int iDProducto)
        {
            return _productoServices.GetPrecioPrd(iDProducto);
        }

        public List<ProductoDescripcion> GetCatalogoByProveedor(int provCode)
        {
            var Catalogo = _productoServices.GetCatalogoByProveedor(provCode);
            List<ProductoDescripcion> retCatalog = new List<ProductoDescripcion>();
            foreach (var p in Catalogo)
            {
                retCatalog.Add(new ProductoDescripcion() {
                    Code = p.code,
                    Descripcion = p.Descripcion
                });
            }
            return retCatalog;
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
                    Categoria = prd.Categoria,
                    ImagenByte = _productoServices.GetImagenProducto((int)prd.Id)
                };
                ret.Add(prdRet);
            }
            return ret;
        }

        public List<CategoriaProductos> GetAllCategorias()
        {
            var list = _productoServices.GetAllCategorias();
            List<CategoriaProductos> retList = new List<CategoriaProductos>();
            foreach (var item in list)
            {
                retList.Add(new CategoriaProductos()
                            {
                                Code = item.Code,
                                Descripcion = item.Descripcion
                            });
            }
            return retList;
        }

        public decimal GetPrecioPrdByListPrice(int iDProducto, int listCode)
        {
            return _productoServices.GetPrecioPrdByList(iDProducto, listCode);
            
        }

        public List<ProveedorType> GetAllTypes()
        {
            List<ProveedorType> retList = new List<ProveedorType>();
            foreach (var type in _productoServices.GetAllTypes())
                retList.Add(new ProveedorType() { Code = type.Code, Descripcion = type.Descripcion });
            return retList;
        }

        public void SaveType(ProveedorType type)
        {
            _productoServices.SaveType(type);
        }

        public void EliminarType(int code)
        {
            _productoServices.EliminarProductType(code);
        }
    }
}
