using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cudo.Models
{
    public partial class cudoContext : DbContext
    {
        public cudoContext()
        {
        }

        public cudoContext(DbContextOptions<cudoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=cudo;user=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.HasIndex(e => e.UsuarioIdUsuario, "fk_Persona_Usuario");

                entity.Property(e => e.IdPersona).ValueGeneratedNever();

                entity.Property(e => e.Correo).HasMaxLength(60);

                entity.Property(e => e.Nombre).HasMaxLength(45);

                entity.Property(e => e.UsuarioIdUsuario).HasColumnName("Usuario_IdUsuario");

                entity.HasOne(d => d.UsuarioIdUsuarioNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.UsuarioIdUsuario)
                    .HasConstraintName("fk_Persona_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(45)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(45)
                    .HasColumnName("Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
