namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Producto")]
    public partial class Producto
    {
        [Key]
        public int idProducto { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "blob")]
        public byte[] Foto { get; set; }

        public int? idCategoria { get; set; }

        [StringLength(100)]
        public string Activo { get; set; }
    }
}
