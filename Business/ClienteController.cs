using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class ClienteController
    {
        private readonly ClienteServices _clienteServices = new ClienteServices();

        public void AgregarCliente(Cliente client)
        {
            _clienteServices.InsertCliente("");
        }
        public void EditarCliente(string descripcion, int id)
        {
            _clienteServices.ActualizarCliente(descripcion, id);
        }
        public void EliminarCliente(int id)
        {
            _clienteServices.DeleteCliente(id);
        }
        public Cliente GetCliente(int id)
        {
            var prd = _clienteServices.getClienteByID(id);
            return new Cliente()
            /*{
            //    IDProducto = (int)prd.Id,
            //    Descripcion = prd.Descripcion,
            //    ProductType = prd.ProductType,
            //    Categoria = prd.Categoria
            }*/;
        }

        public object GetAllClientes()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetClientes()
        {
            var alga = _clienteServices.GetAllClientes();
            List<Cliente> ret = new List<Cliente>();
            foreach (var prd in alga)
            {
                Cliente prdRet = new Cliente()
                /*{
                //    IDProducto = (int)prd.Id,
                //    Descripcion = prd.Descripcion,
                //    ProductType = prd.ProductType,
                //    Categoria = prd.Categoria
                }*/;
                ret.Add(prdRet);
            }
            return ret;
        }
    }
}
