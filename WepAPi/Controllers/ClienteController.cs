using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPi.Models;

namespace WepAPi.Controllers
{
    public class ClienteController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        // GET: api/Cliente
        public IHttpActionResult Get()
        {
            var result = conection.GetCliente();

            var reultString = result.ToList();

            return Json(reultString);
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        public IHttpActionResult Post([FromBody] Cliente cliente)
        {
            System.Data.Entity.Core.Objects.ObjectResult<GetClienteLogin_Result> resultado = null;

            if (cliente.Nombre != null)
            {
                
                conection.InsertCliente(cliente.Nombre, cliente.Contrasenia, cliente.Email, cliente.Telefono, cliente.Longitud, cliente.Latitud);

            }
            else
            {
                if ( cliente.idCliente>0)
                {
                    conection.UpdateUbicaion(cliente.Longitud, cliente.Latitud, cliente.idCliente);
                }
                else
                {
                    resultado = conection.GetClienteLogin(cliente.Email, cliente.Contrasenia);
                }

            }



            return Json(resultado);
        }

       

        

        // DELETE: api/Cliente
        public void Delete(string nombre, string contrasenia, string email, string telefono, string longitud, string latitud, int id)
        {
            var resultado = conection.UpdateCliente(nombre, contrasenia, email, telefono, longitud, latitud,id);


        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        
    }
}
