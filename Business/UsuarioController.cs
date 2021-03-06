﻿using System;
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

        public int iniciarSesion(string username, string password)
        {
            return _usuarioServices.ExistUser(username, password);
        }

        public List<Usuario> GetAllUsuarios()
        {
            var listUser = _usuarioServices.GetAllUsuarios();
            List<Usuario> retList  = new List<Usuario>();
            foreach (var u in listUser)
            {
                retList.Add(new Usuario()
                {
                    IDUser = u.UserId,
                    Apellido = u.Apellido,
                    Nombre = u.Nombre,
                    FechaNac = u.FechaNac.Date,
                    Sex = (u.Sexo == "M") ? true : false,
                    SexDescription = (u.Sexo == "M") ? "Masculino" : "Femenino",
                    UserName = u.userName,
                    UserType = u.UserType
                });
            }
            return retList;
        }

        public Usuario GetUsuarioById(int userCode)
        {
            var getuser = _usuarioServices.GetUserByID(userCode);
            return new Usuario()
            {
                IDUser = getuser.UserId,
                Apellido = getuser.Apellido,
                Nombre = getuser.Nombre,
                FechaNac = getuser.FechaNac,
                Sex = (getuser.Sexo == "M") ? true : false,
                SexDescription = (getuser.Sexo == "M") ? "Masculino" : "Femenino",
                UserName = getuser.userName,
                UserTypeCode = (int)getuser.UserTypeCode,
                UserType = getuser.UserType
            };
        }

        //public object GetDomiciliosUsuario(int iDUser)
        //{
        //    List<Direccion> retList = new List<Direccion>();
        //    var domicilios = _usuarioServices.GetDomiciliosUsuario(iDUser);
        //    if(domicilios != null)
        //    {
        //        foreach (var i in domicilios)
        //            retList.Add(new Direccion()
        //            {
        //                ID = i.Code,
        //                Provincia = i.Provincia,
        //                Localidad = i.Localidad,
        //                Calle = i.Calle,
        //                Altura = i.AlturaCalle
        //            });
        //    }
        //    return retList;
        //}

        public List<UserTypes> GetAllUserTypes()
        {
            List<UserTypes> list = new List<UserTypes>();
            foreach (var item in _usuarioServices.GetAllUserTypes())
                list.Add(new UserTypes() { Code = item.Code, Descripcion = item.Descripcion });
            return list;
        }

        public void SaveUser(Usuario user)
        {
            try
            {
                _usuarioServices.SaveRepresentative(user);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void EliminarUsuario(int iDUser)
        {
            _usuarioServices.DeleteUser(iDUser);
        }

        public bool AccessToModulo(string modulo, int iDUser)
        {
            return _usuarioServices.AccessModulo(modulo, iDUser);
        }
    }
}
