using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Registro_Visita_Api.Persistencia
{
    public partial class Registros_VisistasContext : DbContext
    {
        public string Conec { get; set; }
        public Registros_VisistasContext(IConfiguration configuration)
        {
            Conec = configuration.GetConnectionString("VisitaConexion");
        }

        public Registros_VisistasContext(DbContextOptions<Registros_VisistasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EventoVisitanteTran> EventoVisitanteTrans { get; set; }
        public virtual DbSet<EventosTran> EventosTrans { get; set; }
        public virtual DbSet<HistoricoVisitum> HistoricoVisita { get; set; }
        public virtual DbSet<HistoricosMovimiento> HistoricosMovimientos { get; set; }
        public virtual DbSet<VisitantesTran> VisitantesTrans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-97L1R409\\SQLEXPRESS;Database=Registros_Visistas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EventoVisitanteTran>(entity =>
            {
                entity.HasKey(e => e.EventoVisitanteId)
                    .HasName("PK__Evento_V__9BE2F55E404C1B6D");

                entity.ToTable("Evento_Visitante_Trans");

                entity.Property(e => e.EventoVisitanteId).HasColumnName("Evento_Visitante_id");

                entity.Property(e => e.EventoId).HasColumnName("Evento_id");

                entity.Property(e => e.RegistroEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Estado")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Registro_Fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Usuario")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.VisitanteId).HasColumnName("visitante_id");

                entity.HasOne(d => d.Evento)
                    .WithMany(p => p.EventoVisitanteTrans)
                    .HasForeignKey(d => d.EventoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evento_Vi__Event__5EBF139D");

                entity.HasOne(d => d.Visitante)
                    .WithMany(p => p.EventoVisitanteTrans)
                    .HasForeignKey(d => d.VisitanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evento_Vi__visit__5DCAEF64");
            });

            modelBuilder.Entity<EventosTran>(entity =>
            {
                entity.HasKey(e => e.EventoId)
                    .HasName("PK__Eventos___4E9C4E46B620B8A2");

                entity.ToTable("Eventos_Trans");

                entity.Property(e => e.EventoId).HasColumnName("Evento_id");

                entity.Property(e => e.EventoDescripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Evento_descripcion");

                entity.Property(e => e.EventoFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Evento_Fecha");

                entity.Property(e => e.EventoHora)
                    .HasColumnType("datetime")
                    .HasColumnName("Evento_Hora");

                entity.Property(e => e.EventoNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Evento_Nombre");

                entity.Property(e => e.RegistroEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Estado")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Registro_Fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Usuario")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<HistoricoVisitum>(entity =>
            {
                entity.HasKey(e => e.HistoricoId)
                    .HasName("PK__Historic__61A2A727C2DAF2B2");

                entity.ToTable("Historico_Visita");

                entity.Property(e => e.HistoricoId).HasColumnName("historico_id");

                entity.Property(e => e.HistoricoFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Historico_Fecha");

                entity.Property(e => e.HistoricoHora)
                    .HasColumnType("datetime")
                    .HasColumnName("Historico_Hora");

                entity.Property(e => e.HistoricoNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Historico_Nombre");

                entity.Property(e => e.RegistroEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Estado")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Registro_Fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Usuario")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<HistoricosMovimiento>(entity =>
            {
                entity.HasKey(e => e.HistoricoMovimientoId)
                    .HasName("PK__historic__8934D10384BE0B3A");

                entity.ToTable("historicos_Movimientos");

                entity.Property(e => e.HistoricoMovimientoId).HasColumnName("Historico_Movimiento_id");

                entity.Property(e => e.EventosId).HasColumnName("Eventos_id");

                entity.Property(e => e.MovimientoFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Movimiento_Fecha");

                entity.Property(e => e.RegistroEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Estado")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Registro_Fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Usuario")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.VisitanteId).HasColumnName("Visitante_id");
            });

            modelBuilder.Entity<VisitantesTran>(entity =>
            {
                entity.HasKey(e => e.VisitanteId)
                    .HasName("PK__Visitant__092A5395893C8B49");

                entity.ToTable("Visitantes_Trans");

                entity.Property(e => e.VisitanteId).HasColumnName("visitante_id");

                entity.Property(e => e.RegistroEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Estado")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("Registro_Fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Registro_Usuario")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.VisitaApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Visita_Apellido");

                entity.Property(e => e.VisitaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Visita_Nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
