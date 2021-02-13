using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WepAPi.Models;


namespace WepAPi.Controllers
{
    public class CategoriasController : ApiController
    {


       
        IRagazziEntities conection = new IRagazziEntities();

       

        // GET: api/Categorias
        public IHttpActionResult Get()
        {

           
            
            var result = conection.GetCotegorias();

            var reultString = result.ToList();
           

            return Json(reultString);
        }

        // GET: api/Categorias/5
        public IHttpActionResult Get(int id)
        {

            var result = conection.GetCategoriasId(id);


            var reultString = result.ToList();


            return Json(reultString);

        }

        // POST: api/Categorias
        public void Post(string nombre , int activo)
        {
            conection.InsertCategoria(nombre,activo);
         
        }

        // PUT: api/Categorias/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categorias/5
        public void Delete(int id,int activo)
        {

            conection.UpdateCategoria(id,activo);

        }
    }
}
