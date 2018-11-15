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
        public int ExistUser(string user, string password)
        {
            var val = (int)_data.SP_validateUser(user, password).FirstOrDefault();
            return val;
        }

        public List<SP_Get_All_Usuarios_Result> GetAllUsuarios()
        {
            return _data.SP_Get_All_Usuarios().ToList();
        }

        public SP_Get_Usuario_byID_Result GetUserByID(int UserCode)
        {
            return _data.SP_Get_Usuario_byID(UserCode).FirstOrDefault();
        }

        public void SaveRepresentative(Usuario user)
        {
            if (user.IDUser == 0 || user.IDUser == null)
            {
                var retCode = _data.SP_Insert_Representative(user.Nombre, user.Apellido, user.SexDescription, user.FechaNac).FirstOrDefault();
                user.IDUser = int.Parse(retCode.ToString());
                _data.SP_Insert_User(user.IDUser, user.UserTypeCode);
                foreach (var direc in user.DomicilioUser)
                {
                    int direccionCode = int.Parse(_data.SP_Insert_Direccion(direc.Provincia, direc.Localidad, direc.Calle, direc.Altura).ToString());
                    _data.SP_Insert_Direccion_Usuario(user.IDUser, 2);
                }    
            }
            else
            {
                _data.SP_Update_Representative(user.IDUser, user.Nombre, user.Apellido, user.SexDescription, user.FechaNac);
                _data.SP_Update_User(user.IDUser, user.UserTypeCode);
                foreach (var direc in user.DomicilioUser)
                {
                    _data.SP_Update_Direccion(direc.ID, direc.Provincia, direc.Localidad, direc.Calle, direc.Altura);
                    _data.SP_Update_Direccion_Usuario(user.IDUser, direc.ID);
                }
            }
        }

        public object GetDomiciliosUsuario(int iDUser)
        {
            ///_data.SP_Get_DomiciliosByUser(iDUser);
            return new object();
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

        public bool AccessModulo(string modulo, int iDUser)
        {
            var alga = _data.SP_Get_Access_Modulo(modulo, iDUser).FirstOrDefault();
            return bool.Parse(alga.ToString());            
        }
    }
}
