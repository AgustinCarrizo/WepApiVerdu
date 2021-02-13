namespace WepAPi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u711858828_IRagazzi.Empresa")]
    public partial class Empresa
    {
        [Key]
        public int idEmpresa { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        [StringLength(100)]
        public string Rugro { get; set; }

        [StringLength(100)]
        public string Longitud { get; set; }

        [StringLength(100)]
        public string Latitud { get; set; }

        [StringLength(100)]
        public string Contrasenia { get; set; }

        public int? Activo { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
    }
}
