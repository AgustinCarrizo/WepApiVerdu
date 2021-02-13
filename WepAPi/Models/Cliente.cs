namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Cliente")]
    public partial class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Contrasenia { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Longitud { get; set; }

        [StringLength(100)]
        public string Latitud { get; set; }
    }
}
