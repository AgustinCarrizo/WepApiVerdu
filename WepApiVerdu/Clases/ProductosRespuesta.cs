using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepApiVerdu.Clases
{
    public class ProductosRespuesta
    {
 
        public int id_Productos { get; set; }

    
        public string Nombre { get; set; }

        public double? Precio { get; set; }

       
        public string Unidad { get; set; }

      
        public string Foto { get; set; }

        public int id_Categorias { get; set; }

     
        public string Descripcion { get; set; }

        public int Activo { get; set; }

        public int ActvioCarrito { get; set; }

        public string Categorias  { get; set; }
    }
}