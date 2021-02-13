namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.FormaDePago")]
    public partial class FormaDePago
    {
        [Key]
        public int idFormaPago { get; set; }

        [StringLength(100)]
        public string Forma { get; set; }

        public int? Activo { get; set; }
    }
}
