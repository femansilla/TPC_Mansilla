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

        public void GuardarCliente(Cliente client)
        {
            _clienteServices.SaveCliente(client);
        }

        public void EliminarCliente(int id)
        {
            _clienteServices.DeleteCliente(id);
        }

        public Cliente GetCliente(int id)
        {
            var i = _clienteServices.getClienteByID(id);
            return new Cliente()
            {
                ID = i.code,
                Nombre = i.Nombre,
                Apellido = i.Apellido,
                CUIT = i.CUIT,
                Sex = (i.Sexo == "M") ? true : false,
                SexDescription = (i.Sexo == "M") ? "Masculino" : "Femenino",
                FechaNac = i.FechaNac
            };
        }

        public object GetAllClientes()
        {
            List<Cliente> retList = new List<Cliente>();
            var a = _clienteServices.GetAllClientes();
            foreach (var i in a)
            {
                retList.Add(new Cliente()
                {
                    ID = i.code,
                    Nombre = i.Nombre,
                    Apellido = i.Apellido,
                    CUIT = i.CUIT,
                    Sex = (i.Sexo == "M") ? true : false,
                    SexDescription = (i.Sexo == "M") ? "Masculino" : "Femenino",
                    FechaNac = i.FechaNac
                });
            }
            return retList;
        }

    }
}
