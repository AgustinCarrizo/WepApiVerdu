using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPi.Models;

namespace WepAPi.Controllers
{
    public class EmpreProducController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        // GET: api/EmpreProduc
        public IHttpActionResult Get(int id)
        {

            var resultado = conection.GetEmpreProducIdEmpresa(id);

            return Json(resultado);
        }

        // GET: api/EmpreProduc/5
        public IHttpActionResult Get(int id , int cliente)
        {
            var resultado = conection.ListadoProductoCliente(cliente);

            return Json(resultado);
        }

        // POST: api/EmpreProduc
        public void Post(int idProducto , int idEmpresa , string precio , string descripcion , string preciodesc , int stock , int activo)
        {
            conection.InsertEmpreProduc(idProducto,idEmpresa,precio,descripcion,preciodesc,stock,activo);

        }

        // PUT: api/EmpreProduc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmpreProduc/5
        public void Delete(int idProducto, int idEmpresa, string precio, string descripcion, string preciodesc, int stock, int activo ,int id)
        {
            conection.UpdateEmpreProduc(idProducto, idEmpresa, precio, descripcion, preciodesc, stock, activo, id);
        }
    }
}
