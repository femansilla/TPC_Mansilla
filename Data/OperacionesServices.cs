using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class OperacionesServices
    {
        private static DESA _data = new DESA();

        public IEnumerable<SP_Get_All_Compras_Result> GetAllCompras()
        {
            return _data.SP_Get_All_Compras().ToList();
        }

        public IEnumerable<SP_Get_All_Ventas_Result> GetAllVentas()
        {
            return _data.SP_Get_All_Ventas().ToList();
        }

        public List<ProductoOperacion> GetProductoByOperacion(string tipo, int code)
        {
            List<ProductoOperacion> retList = new List<ProductoOperacion>();
            if (tipo != "Compra")
            {
                var list = _data.SP_Get_ProductosVenta_ByID(code).ToList();
                foreach (var i in list)
                {
                    retList.Add(new ProductoOperacion()
                    {
                        Descripcion = i.Descripcion,
                        Precio = i.ImporteUnidad,
                        Cantidad = i.Cantidad,
                        Subtotal = (i.Cantidad * i.ImporteUnidad)
                    });
                }

            }
            else
            {
                var list = _data.SP_Get_ProductosCompra_ByID(code).ToList();

                foreach (var i in list)
                {
                    retList.Add(new ProductoOperacion()
                    {
                        Descripcion = i.Descripcion,
                        Precio = i.ImporteUnidad,
                        Cantidad = i.Cantidad,
                        Subtotal = (i.Cantidad * i.ImporteUnidad)
                    });
                }
            }
            return retList;
        }

        public object GetOperacion(string tipo, int code)
        {
            if(tipo != "Compra")
                return _data.SP_Get_Venta(code).FirstOrDefault();
            else
                return _data.SP_Get_Compra(code).FirstOrDefault();
        }

        public void SaveCompra(Compra cmp)
        {
            var code = _data.SP_Insert_Compra(cmp.ProveedorCode, cmp.Fecha, cmp.Referencia, cmp.EstadoCode, 1).FirstOrDefault();
            cmp.CodigoOperacion = (int)code;
            CargarProductosEnOperacion(cmp.TipoOperacion, cmp.CodigoOperacion, cmp.ProductosCompra);
        }

        public void SaveVenta(Venta vts)
        {
            vts.CodigoOperacion = _data.SP_Insert_Venta(vts.ClienteCode, vts.Fecha, vts.Referencia, vts.EstadoCode, 1).FirstOrDefault().Value;
            CargarProductosEnOperacion(vts.TipoOperacion, vts.CodigoOperacion, vts.ProductosVenta);
        }

        public void UpdateOperacion(string tipo, int operacionCode, int estadoCode)
        {
            if (tipo != "Compra")
            {
                _data.SP_Update_Compra(operacionCode, estadoCode);
            }            
            else         
            {             
                _data.SP_Update_Venta(operacionCode, estadoCode);
            }
        }

        public void CargarProductosEnOperacion(string tipo, int CodeOperacion, List<ProductoOperacion> prds)
        {
            if(tipo != "Compra")
                foreach (var prd in prds)
                    _data.SP_Insert_Producto_ByVenta(CodeOperacion, prd.IDProducto, prd.Precio, prd.Cantidad);
            else
                foreach (var prd in prds)
                    _data.SP_Insert_Producto_ByCompra(CodeOperacion, prd.IDProducto, prd.Precio, prd.Cantidad);


        }

        public List<ProveedorType> GetAllEstadosForOperacion()
        {
            ProveedorType Estado1 = new ProveedorType() { Code = 1, Descripcion = "Ingresado" };
            ProveedorType Estado2 = new ProveedorType() { Code = 2, Descripcion = "Procesado" };
            ProveedorType Estado3 = new ProveedorType() { Code = 3, Descripcion = "Pagado" };
            ProveedorType Estado4 = new ProveedorType() { Code = 4, Descripcion = "Cancelado" };

            List<ProveedorType> retList = new List<ProveedorType>();
            retList.Add(Estado1);
            retList.Add(Estado2);
            retList.Add(Estado3);
            retList.Add(Estado4);

            return retList;
        }
    }
}
