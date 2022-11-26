using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test.Domain.Model.DbModel
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Test;TrustServerCertificate=true;Integrated Security=True;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compra>(entity =>
            {
                entity.Property(e => e.ClienteId).HasMaxLength(1);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasColumnName("")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.SituacionLaboral).HasMaxLength(50);

                entity.Property(e => e.TipoCliente).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });
        }
    }
}
