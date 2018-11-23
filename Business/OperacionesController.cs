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
        private readonly ClienteServices _clienteServices = new ClienteServices();

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
                    Fecha = i.DateCompra.Date,
                    Nombre = i.Nombre,
                    Apellido = i.Apellido,
                    CUIT = i.CUIT,
                    Referencia = i.Referencia,
                    Importe = i.TotalCompra,
                    Estado = i.Estado,
                    UsuarioRealizoAccion = _operacionesServices.GetUserAccionByCompra(i.Code),
                    ProductosCompra = _operacionesServices.GetProductoByOperacion("Compra", i.Code),
                });
            }
            return retList;
        }

        public Operacion GetOperacion(string tipo, int code)
        {
            if(tipo != "Compra")
            {
                SP_Get_Venta_Result op = _operacionesServices.GetOperacion(tipo, code) as SP_Get_Venta_Result;
                return new Venta()
                {
                    ClienteCode = (int)op.clientCode,
                    Fecha = op.date,
                    Referencia = op.referencia,
                    ProductosVenta = _operacionesServices.GetProductoByOperacion("Venta", code),
                    EstadoCode = (int)op.estado,
                    UsuarioRealizoAccion = op.user
                };
            }
            else
            {
                SP_Get_Compra_Result op = _operacionesServices.GetOperacion(tipo, code) as SP_Get_Compra_Result;
                return new Compra()
                {
                    ProveedorCode = op.proveedorCode,
                    Fecha = op.date,
                    Referencia = op.referencia,
                    ProductosCompra = _operacionesServices.GetProductoByOperacion("Compra", code),
                    EstadoCode = (int)op.estado,
                    UsuarioRealizoAccion = op.user
                };
            }
        }

        public List<Venta> GetAllVentas()
        {
            List<Venta> retList = new List<Venta>();
            var list = _operacionesServices.GetAllVentas();
            foreach (var i in list)
            {
                var client = _clienteServices.getClienteByID((int)i.ClienteCode);
                retList.Add(new Venta() {
                    CodigoOperacion = i.Code,
                    Fecha = i.DateCompra.Date,
                    ClienteCode = (int)i.ClienteCode,
                    Cliente = (client == null) ? "Mostrador" : client.Apellido + ", " + client.Nombre,
                    Referencia = i.Referencia,
                    Estado = i.Estado,
                    ProductosVenta = _operacionesServices.GetProductoByOperacion("Venta", i.Code),
                    Total = (i.ImporteTotal != null) ? (decimal)i.ImporteTotal : 0,
                    UsuarioRealizoAccion = _operacionesServices.GetUsertAccionByVenta(i.Code)
                });
            }
            return retList;
        }

        public void CancelarOperacion(string tipo, int operacionCode)
        {
            _operacionesServices.UpdateOperacion(tipo, operacionCode, 4);
        }
        public void ModificarEstadoOperacion(string tipo, int operacionCode, int estadoCode)
        {
            _operacionesServices.UpdateOperacion(tipo, operacionCode, estadoCode);
        }
        public List<ProveedorType> GetAllEstadosForOperacion()
        {
            return _operacionesServices.GetAllEstadosForOperacion();
        }
    }
}
