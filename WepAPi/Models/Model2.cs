namespace WepAPi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model21")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<DetalleCompras> DetalleCompras { get; set; }
        public virtual DbSet<EmpreProduc> EmpreProduc { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<FormaDePago> FormaDePago { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Longitud)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Latitud)
                .IsUnicode(false);

            modelBuilder.Entity<Compras>()
                .Property(e => e.Total)
                .IsUnicode(false);

            modelBuilder.Entity<EmpreProduc>()
                .Property(e => e.Precio)
                .IsUnicode(false);

            modelBuilder.Entity<EmpreProduc>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EmpreProduc>()
                .Property(e => e.PrecioDesc)
                .IsUnicode(false);

            modelBuilder.Entity<EmpreProduc>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Rugro)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Longitud)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Latitud)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<FormaDePago>()
                .Property(e => e.Forma)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Activo)
                .IsUnicode(false);
        }
    }
}
