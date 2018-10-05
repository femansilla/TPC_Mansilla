﻿using System;
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

        public void AgregarCliente(Producto prd)
        {
            _clienteServices.InsertCliente(prd.Descripcion);
        }
        public void EditarCliente(string descripcion, int id)
        {
            _clienteServices.ActualizarCliente(descripcion, id);
        }
        public void EliminarCliente(int id)
        {
            _clienteServices.DeleteCliente(id);
        }
        public Producto GetCliente(int id)
        {
            var prd = _clienteServices.getClienteByID(id);
            return new Producto()
            {
                IDProducto = (int)prd.Id,
                Descripcion = prd.Descripcion,
                ProductType = prd.ProductType,
                Categoria = prd.Categoria
            };
        }
        public List<Producto> GetClientes()
        {
            var alga = _clienteServices.GetAllCliente();
            List<Producto> ret = new List<Producto>();
            int i = 1;
            foreach (var prd in alga)
            {
                Producto prdRet = new Producto()
                {
                    IDProducto = (int)prd.Id,
                    Descripcion = prd.Descripcion,
                    ProductType = prd.ProductType,
                    Categoria = prd.Categoria
                };
                ret.Add(prdRet);
            }
            return ret;
        }
    }
}
