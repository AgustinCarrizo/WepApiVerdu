namespace WepApiVerdu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Compra")]
    public partial class Compra
    {
        public int id { get; set; }

        public int id_Registros { get; set; }

        [Required]
        [StringLength(500)]
        public string Productos { get; set; }

        [Required]
        [StringLength(50)]
        public string PrecioTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string Pago { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        public int Entregado { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int? Codigo { get; set; }

        public virtual Registros Registros { get; set; }

        public virtual influencer influencer { get; set; }
    }
}
