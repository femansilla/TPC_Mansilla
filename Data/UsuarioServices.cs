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

        public List<SP_Get_All_Usuarios_Result> GetAllUsuarios()
        {
            return _data.SP_Get_All_Usuarios().ToList();
        }

        public SP_Get_Usuario_byID_Result GetUserByID(int UserCode)
        {
            return _data.SP_Get_Usuario_byID(UserCode).FirstOrDefault();
        }

        public void SaveRepresentative(int userCode, string nombre, string apellido, bool sex, DateTime fechaNac)
        {
            //insert representante, calcular userid
        }

        private void SaveUser(int userCode, int userType)
        {
            //_data.SP_Insert_Usuario(userType);
        }

        public void DeleteUser(int UserCode)
        {
            //_data.SP_Delete_Usuario(id);
        }

        public void ActualizarUser(int UserCode)
        {
            //_data.SP_update_Descripcion_Usuario(Descripcion, idUsuario);
        }

        public List<SP_get_all_userTypes_Result> GetAllUserTypes()
        {
            return _data.SP_get_all_userTypes().ToList();
        }
    }
}
