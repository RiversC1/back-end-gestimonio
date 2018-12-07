using System;
using Gestimonio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gestimonio.Repository.SqlServer
{
    public partial class gestimonio2Context : DbContext
    {
        public gestimonio2Context()
        {
        }

        public gestimonio2Context(DbContextOptions<gestimonio2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TbEstado> TbEstado { get; set; }
        public virtual DbSet<TbReserva> TbReserva { get; set; }
        public virtual DbSet<TbSemana> TbSemana { get; set; }
        public virtual DbSet<TbTipoCargo> TbTipoCargo { get; set; }
        public virtual DbSet<TbTipoDocumento> TbTipoDocumento { get; set; }
        public virtual DbSet<TbTrabajador> TbTrabajador { get; set; }
        public virtual DbSet<TbUsuario> TbUsuario { get; set; }
        public virtual DbSet<TbVisitante> TbVisitante { get; set; }

        // Unable to generate entity type for table 'dbo.Tb_areaComun'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tb_ReciboCobranza'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado);

                entity.ToTable("Tb_estado");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigoEstado");

                entity.Property(e => e.DescripcionEstado)
                    .HasColumnName("descripcionEstado")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbReserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);

                entity.ToTable("tb_Reserva");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("idReserva")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CantidaHoraMax).HasColumnName("cantidaHoraMax");

                entity.Property(e => e.CodigoAreaComun)
                    .HasColumnName("codigoAreaComun")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoUsuario).HasColumnName("codigoUsuario");

                entity.Property(e => e.CodigoVisitante).HasColumnName("codigoVisitante");

                entity.Property(e => e.EstadoReserva)
                    .HasColumnName("estadoReserva")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaReserva)
                    .HasColumnName("fechaReserva")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TbSemana>(entity =>
            {
                entity.HasKey(e => e.CodigoSemana);

                entity.ToTable("Tb_Semana");

                entity.Property(e => e.CodigoSemana)
                    .HasColumnName("codigoSemana")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoCargo>(entity =>
            {
                entity.HasKey(e => e.CodCargo);

                entity.ToTable("tb_tipoCargo");

                entity.Property(e => e.CodCargo).HasColumnName("cod_cargo");

                entity.Property(e => e.DesCargo)
                    .HasColumnName("des_cargo")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoDocumento);

                entity.ToTable("tb_tipoDocumento");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigoTipoDocumento");

                entity.Property(e => e.DescripcionTipoDoc)
                    .HasColumnName("descripcionTipoDoc")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTrabajador>(entity =>
            {
                entity.HasKey(e => e.CodigoTrabajador);

                entity.ToTable("tb_Trabajador");

                entity.Property(e => e.CodigoTrabajador).HasColumnName("codigoTrabajador");

                entity.Property(e => e.ApellidoTrabajador)
                    .HasColumnName("apellidoTrabajador")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCargo).HasColumnName("codigoCargo");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigoEstado");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigoTipoDocumento");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fechaIngreso")
                    .HasColumnType("date");

                entity.Property(e => e.NombreTrabajador)
                    .HasColumnName("nombreTrabajador")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.CodigoUsuario);

                entity.ToTable("Tb_Usuario");

                entity.Property(e => e.CodigoUsuario).HasColumnName("codigoUsuario");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCargo).HasColumnName("codigoCargo");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigoEstado");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigoTipoDocumento");

                entity.Property(e => e.Contrasena)
                    .HasColumnName("contrasena")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fechaIngreso")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbVisitante>(entity =>
            {
                entity.HasKey(e => e.CodigoVisitante);

                entity.ToTable("tb_Visitante");

                entity.Property(e => e.CodigoVisitante).HasColumnName("codigoVisitante");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigoTipoDocumento");

                entity.Property(e => e.Dni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
