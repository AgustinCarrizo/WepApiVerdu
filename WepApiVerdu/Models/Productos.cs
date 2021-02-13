namespace WepApiVerdu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Productos")]
    public partial class Productos
    {
        [Key]
        public int id_Productos { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public double? Precio { get; set; }

        [Required]
        [StringLength(50)]
        public string Unidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Foto { get; set; }

        public int id_Categorias { get; set; }

        [StringLength(450)]
        public string Descripcion { get; set; }

        public int Activo { get; set; }

        public int ActvioCarrito { get; set; }

        public virtual Categorias Categorias { get; set; }
    }
}
