using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {

        private readonly Business.ProductoController _prdControl = new Business.ProductoController();
        // GET api/<controller>
        public IEnumerable<Producto> Get()
        {
            return _prdControl.GetProductos();
        }

        // GET api/<controller>/5
        public Producto Get(int id)
        {
            return _prdControl.GetProducto(id);
        }

        // POST api/<controller>
        public void Post(Producto prd)
        {
            try
            {
                _prdControl.SaveProducto(prd.IDProducto, prd.Descripcion, int.Parse(prd.ProductType), prd.Imagen);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // PUT api/<controller>/5
        //public void Put(Producto prd)
        //{
        //    try
        //    {
        //        _prdControl.SaveProducto(prd.IDProducto, prd.Descripcion, int.Parse(prd.ProductType), prd.Imagen);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            try
            {
                _prdControl.EliminarProducto(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Producto> All()
        {
            try
            {
                return _prdControl.GetProductos();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}