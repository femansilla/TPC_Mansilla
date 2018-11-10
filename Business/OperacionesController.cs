using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class OperacionesController
    {
        private readonly OperacionesServices _operacionesServices = new OperacionesServices();

        public bool SaveCompra(Compra cmp)
        {
            _operacionesServices.SaveCompra(cmp);
            return true;
        }

        public bool SaveVenta(Venta vts)
        {
            _operacionesServices.SaveVenta(vts);
            return true;
        }

        public List<Compra> GetAllCompras()
        {
            List<Compra> retList = new List<Compra>();
            var list = _operacionesServices.GetAllCompras();
            foreach (var i in list)
            {
                retList.Add(new Compra()
                {
                    CodigoOperacion = i.Code,
                    Fecha = i.DateCompra,
                    Nombre = i.Nombre,
                    Apellido = i.Apellido,
                    CUIT = i.CUIT,
                    Referencia = i.Referencia,
                    Importe = i.TotalCompra,
                    Estado = i.Estado,
                    ProductosCompra = _operacionesServices.GetProductoByOperacion("Compra", i.Code),
                    EstadoCode = i.Estado
                });
            }
            return retList;
        }

        public List<Venta> GetAllVentas()
        {
            List<Venta> retList = new List<Venta>();
            var list = _operacionesServices.GetAllVentas();
            foreach (var i in list)
            {
                retList.Add(new Venta() {
                    CodigoOperacion = i.Code,
                    Fecha = i.DateCompra,
                    ClienteCode = (int)i.ClienteCode,
                    Referencia = i.Referencia,
                    Estado = i.Estado,
                    ProductosVenta = _operacionesServices.GetProductoByOperacion("Venta", i.Code)
                });
            }
            return retList;
        }

        public List<ProveedorType> GetAllEstadosForOperacion()
        {
            return _operacionesServices.GetAllEstadosForOperacion();
        }
    }
}
