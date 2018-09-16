using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class UsuarioController
    {
        private UsuarioServices _usuarioServices = new UsuarioServices();

        public bool iniciarSesion(string username, string password)
        {
            return _usuarioServices.ExistUser(username, password);
        }


    }
}
