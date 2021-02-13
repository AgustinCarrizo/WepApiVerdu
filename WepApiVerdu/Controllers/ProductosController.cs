using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WepApiVerdu.Clases;
using WepApiVerdu.Models;

namespace WepApiVerdu.Controllers
{
    public class ProductosController : ApiController
    {
        private Model1 db = new Model1();

        public ProductosController()
        {

        }

        // GET: api/Productos
        public List<ProductosRespuesta> GetProductos()
        {
            var producto = db.Productos.ToList();

            List<ProductosRespuesta> listProductos = new List<ProductosRespuesta>();
            foreach (var productos in producto)
            {
                ProductosRespuesta respuesta = new ProductosRespuesta();
                respuesta.id_Productos = productos.id_Productos;
                respuesta.Nombre = productos.Nombre;
                respuesta.Precio = productos.Precio;
                respuesta.Unidad = productos.Unidad;
                respuesta.Foto = productos.Foto;
                respuesta.id_Categorias = productos.id_Categorias;
                respuesta.Descripcion = productos.Descripcion;
                respuesta.Activo = productos.Activo;
                respuesta.ActvioCarrito = productos.ActvioCarrito;
                respuesta.Categorias = productos.Categorias.Categorias1;

                listProductos.Add(respuesta);
            }


            return listProductos;
        }

        // GET: api/Productos/5
        [ResponseType(typeof(Productos))]
        public IHttpActionResult GetProductos(int id)
        {
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return NotFound();
            }

            ProductosRespuesta respuesta = new ProductosRespuesta();

            respuesta.id_Productos = productos.id_Productos;

            respuesta.Nombre = productos.Nombre;
            respuesta.Precio = productos.Precio;
            respuesta.Unidad = productos.Unidad;
            respuesta.Foto = productos.Foto;
            respuesta.id_Categorias = productos.id_Categorias;
            respuesta.Descripcion = productos.Descripcion;
            respuesta.Activo = productos.Activo;
            respuesta.ActvioCarrito = productos.ActvioCarrito;
            respuesta.Categorias = productos.Categorias.Categorias1;




            return Ok(respuesta);
        }

        // PUT: api/Productos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductos(int id, Productos productos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productos.id_Productos)
            {
                return BadRequest();
            }

            db.Entry(productos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Productos
        [ResponseType(typeof(Productos))]
        public IHttpActionResult PostProductos(Productos productos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Productos.Add(productos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = productos.id_Productos }, productos);
        }

        // DELETE: api/Productos/5
        [ResponseType(typeof(Productos))]
        public IHttpActionResult DeleteProductos(int id)
        {
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return NotFound();
            }

            db.Productos.Remove(productos);
            db.SaveChanges();

            return Ok(productos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductosExists(int id)
        {
            return db.Productos.Count(e => e.id_Productos == id) > 0;
        }
    }
}