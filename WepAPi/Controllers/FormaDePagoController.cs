using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPi.Models;

namespace WepAPi.Controllers
{
    public class FormaDePagoController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        // GET: api/FormaDePago
        public IHttpActionResult Get()
        {
            var result = conection.GetFormaDePago();

            var reultString = result.ToList();


            return Json(reultString);
        }

        // GET: api/FormaDePago/5
        public IHttpActionResult Get(int id)
        {
            var result = conection.GetFormaDePagoId(id);

            var reultString = result.ToList();


            return Json(reultString);
        }

        // POST: api/FormaDePago
        public void Post(string nombre, int activo)
        {
            conection.InsertFormaDepago(nombre,activo);
        }

        // PUT: api/FormaDePago/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FormaDePago/5
        public void Delete(int id, int activo)
        {
            conection.UpdateFormaDePago(id, activo);
        }
    }
}
