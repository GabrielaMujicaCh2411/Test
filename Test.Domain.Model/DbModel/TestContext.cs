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

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }

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
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(250);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Afp)
                    .HasColumnName("AFP")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidos).HasMaxLength(250);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(250);
            });
        }
    }
}
