using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPi.Models;

namespace WepAPi.Controllers
{
    public class EmpresaController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        // GET: api/Empresa
        public IHttpActionResult Get()
        {
            var result = conection.GetEmpresas();

            var reultString = result.ToList();

            return Json(reultString);
        }

        // GET: api/Empresa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Empresa
        public IHttpActionResult Post(string email, string contrasenia)
        {
            var resultado = conection.GetEmpresaLogin(email, contrasenia);

            return Json(resultado);
        }

        // POST: api/Empresa
        public void Post(string nombre, string logo , string rugro , string longitud , string latitud , string contrasenia , int activo , string email)
        {
            conection.InsertEmpresa(nombre, logo, rugro, longitud, latitud, contrasenia, activo, email);

        }

        // PUT: api/Empresa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empresa/5
        public void Delete(string nombre, string logo, string rugro, string longitud, string latitud, string contrasenia, int activo, string email, int id)
        {
            conection.UpdateEmpresa(nombre, logo, rugro, longitud, latitud, contrasenia, activo, email, id);
        }
    }
}
