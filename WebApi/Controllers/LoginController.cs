using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        private UsuarioController _usuarioController = new UsuarioController();

        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }
        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            //https://enmilocalfunciona.io/construyendo-una-web-api-rest-segura-con-json-web-token-en-net-parte-ii/
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            int val = _usuarioController.iniciarSesion(login.Username, login.Password);
            if (val != 0)
            {
                //var currUsr =_usuarioController.GetUsuarioById(val);
                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                return Ok(token);
            }
            else
                return Unauthorized();
            //MessageBox.Show("Usuario o clave incorrecto. \r\nVerifique por favor.");
        }
    }
}