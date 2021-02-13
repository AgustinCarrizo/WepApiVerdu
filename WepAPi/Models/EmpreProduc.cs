namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.EmpreProduc")]
    public partial class EmpreProduc
    {
        [Key]
        public int idEmpreProduc { get; set; }

        public int? idProducto { get; set; }

        public int? idEmpresa { get; set; }

        [StringLength(100)]
        public string Precio { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(100)]
        public string PrecioDesc { get; set; }

        public int? Stokc { get; set; }

        [StringLength(100)]
        public string Activo { get; set; }
    }
}
