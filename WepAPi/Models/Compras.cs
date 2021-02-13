namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Compras")]
    public partial class Compras
    {
        [Key]
        public int idCompras { get; set; }

        public int? idEmpresa { get; set; }

        public int? idCliente { get; set; }

        public int? idFormaPago { get; set; }

        [StringLength(100)]
        public string Total { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Rechazo { get; set; }

        public int? Activo { get; set; }
    }
}
