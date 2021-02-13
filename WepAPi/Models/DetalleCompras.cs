namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.DetalleCompras")]
    public partial class DetalleCompras
    {
        [Key]
        public int idDetalleCompras { get; set; }

        public int? idCompras { get; set; }

        public int? idEmpresaProduc { get; set; }

        public int? Cantidad { get; set; }
    }
}
