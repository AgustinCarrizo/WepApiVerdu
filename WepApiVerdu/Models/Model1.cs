namespace WepApiVerdu.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<influencer> influencer { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Registros> Registros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .Property(e => e.Categorias1)
                .IsUnicode(false);

            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categorias)
                .HasForeignKey(e => e.id_Categorias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Productos)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.PrecioTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<influencer>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<influencer>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<influencer>()
                .HasMany(e => e.Compra)
                .WithOptional(e => e.influencer)
                .HasForeignKey(e => e.Codigo);

            modelBuilder.Entity<Login>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Registros>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Registros>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Registros)
                .HasForeignKey(e => e.id_Registros)
                .WillCascadeOnDelete(false);
        }
    }
}
