namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Categoria")]
    public partial class Categoria
    {
        [Key]
        public int idCategoria { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public int? Activo { get; set; }
    }
}
