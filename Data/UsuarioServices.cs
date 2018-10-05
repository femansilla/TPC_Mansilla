using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioServices
    {
        private static DESA _data = new DESA();
        public bool ExistUser(string user, string password)
        {
            var val = _data.SP_validateUser(user, password).FirstOrDefault();
            return (!string.IsNullOrEmpty(val)) ? bool.Parse(_data.SP_validateUser(user, password).FirstOrDefault()) : false;
        }

        public List<object> GetAllUsuarios()
        {
            //return _data.SP_Get_All_Usuarios().ToList();
            return new List<object>();
        }

        public void getUserByID(int UserCode)
        {
            //return _data.SP_Get_Usuario_byID(IdUsuario).FirstOrDefault();
        }

        public void InsertUser(string Descripcion)
        {
            //insert representante, calcular userid
            //_data.SP_Insert_Usuario(Descripcion, 1, 2);
        }

        public void DeleteUser(int UserCode)
        {
            //_data.SP_Delete_Usuario(id);
        }

        public void ActualizarUser(int UserCode)
        {
            //_data.SP_update_Descripcion_Usuario(Descripcion, idUsuario);
        }
    }
}
