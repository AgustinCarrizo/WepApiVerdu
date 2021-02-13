using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPi.Models;

namespace WepAPi.Controllers
{
    public class CompraController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        IRagazziEntities conection1 = new IRagazziEntities();
        IRagazziEntities conection2 = new IRagazziEntities();
        // GET: api/Compra
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Compra/5
        public IHttpActionResult Get(int idCliente)
        {
            var resultado = conection.ListadoComprasCliente(idCliente);

            return Json(resultado);
        }

        public IHttpActionResult Get(int idEmpresa , int Empresa)
        {
            var resultado = conection.ListadoComprasCliente(idEmpresa);

            return Json(resultado);
        }

        // POST: api/Compra
        public IHttpActionResult Post(int idEmpresa,int idCliente , int idFormaPago,string total , DateTime fecha , int rechazo , int activo)
        {

            conection.InsertCompras(idEmpresa, idCliente, idFormaPago, total, fecha, rechazo, activo);

           var resultado = conection1.GetUltimaCompra();

           return Json( resultado); 

        }

        // POST: api/Compra

        public void Post(int idCompra , int idEmpresaPorducto , int cantidad)
        {
            conection.InsertDetalleCompras(idCompra, idEmpresaPorducto, cantidad);
        }




        // PUT: api/Compra/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Compra/5
        public void Delete(int id)
        {
        }
    }
}
