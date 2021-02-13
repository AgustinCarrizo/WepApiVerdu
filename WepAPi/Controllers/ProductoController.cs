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
    public class ProductoController : ApiController
    {
        IRagazziEntities conection = new IRagazziEntities();
        // GET: api/Producto
        public IHttpActionResult Get()
        {
            var result = conection.GetProducto();


            return Json(result);
        }

        // GET: api/Producto/5
        public IHttpActionResult Get(int id)
        {
            var result = conection.GetProductoID(id);


            return Json(result);
        }

        // POST: api/Producto
        public void Post(string nombre,int idcategoria , int activo , string foto)
        {
            byte[] fotoblob = Encoding.ASCII.GetBytes(foto);
            conection.InsertProducto(nombre,idcategoria,activo, fotoblob );
        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Producto/5
        public void Delete(string nombre, int idcategoria, int activo, string foto ,int id)
        {
            byte[] fotoblob = Encoding.ASCII.GetBytes(foto);
            conection.UpdateProductos(nombre,fotoblob,idcategoria,activo,id);
        }
    }
}
