using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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

        public void SaveRepresentative(Usuario user, Direccion direc, int userTypeCode)
        {
            string sexo = (user.Sex) ? "M" : "F";
            user.IDUser = int.Parse(_data.SP_Insert_Representative(user.Nombre, user.Apellido, sexo, user.FechaNac).ToString());
            _data.SP_Insert_User(user.IDUser, userTypeCode);
            _data.SP_Insert_Direccion(direc.Provincia, direc.Localidad, direc.Calle, direc.Altura);
            _data.SP_Insert_Direccion_Usuario(user.IDUser, 2);
        }
        
        private void SaveUser(int userCode, int userType)
        {
            //_data.SP_Insert_Usuario(userCode, userType);
        }

        public void DeleteUser(int UserCode)
        {
            _data.SP_Delete_Representative(UserCode);
            _data.SP_Delete_User(UserCode);
        }

        public List<SP_get_all_userTypes_Result> GetAllUserTypes()
        {
            return _data.SP_get_all_userTypes().ToList();
        }
    }
}
