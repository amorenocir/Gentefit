using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gentefit.Modelo;

public partial class GentefitContext : DbContext
{
    public GentefitContext()
    {
    }

    public GentefitContext(DbContextOptions<GentefitContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividad> Actividads { get; set; }

    public virtual DbSet<Clase> Clases { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<EstadoReserva> EstadoReservas { get; set; }

    public virtual DbSet<Gimnasio> Gimnasios { get; set; }

    public virtual DbSet<Monitor> Monitors { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-C8ANKQP\\SQLEXPRESS;Database=Gentefit;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activida__3214EC27DEE2385C");

            entity.ToTable("Actividad");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Gimnasio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Intensidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.GimnasioNavigation).WithMany(p => p.Actividades)
                .HasForeignKey(d => d.Gimnasio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Actividad_Gimnasio");
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clase__3214EC272040217E");

            entity.ToTable("Clase");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Horario).HasColumnType("datetime");

            entity.HasOne(d => d.ActividadNavigation).WithMany(p => p.Clases)
                .HasForeignKey(d => d.Actividad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Clase_Actividad");

            entity.HasOne(d => d.MonitorNavigation).WithMany(p => p.Clases)
                .HasForeignKey(d => d.Monitor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Clase_Monitor");

            entity.HasOne(d => d.SalaNavigation).WithMany(p => p.Clases)
                .HasForeignKey(d => d.Sala)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Clase_Sala");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC2768363A56");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Gimnasio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GimnasioNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.Gimnasio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Cliente_Gimnasio");
        });

        modelBuilder.Entity<EstadoReserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoRe__3214EC27ED0F059E");

            entity.ToTable("EstadoReserva");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.ReservaNavigation).WithMany(p => p.EstadoReservas)
                .HasForeignKey(d => d.Reserva)
                .HasConstraintName("fk_EstadoReserva_Reserva");
        });

        modelBuilder.Entity<Gimnasio>(entity =>
        {
            entity.HasKey(e => e.Nombre).HasName("PK__Gimnasio__75E3EFCE0CA7D4D3");

            entity.ToTable("Gimnasio");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Monitor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monitor__3214EC272BF7700F");

            entity.ToTable("Monitor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Gimnasio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GimnasioNavigation).WithMany(p => p.Monitores)
                .HasForeignKey(d => d.Gimnasio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Monitor_Gimnasio");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserva__3214EC279A26C7E9");

            entity.ToTable("Reserva");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Clase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("EnEspera");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.Cliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Reserva_Cliente");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC271A97D82B");

            entity.ToTable("Rol");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TipoRol)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sala__3214EC270728BC4D");

            entity.ToTable("Sala");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gimnasio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.GimnasioNavigation).WithMany(p => p.Salas)
                .HasForeignKey(d => d.Gimnasio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Sala_Gimnasio");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC2704BBB9A4");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Gimnasio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idrol).HasColumnName("IDRol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GimnasioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Gimnasio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_Gimnasio");

            entity.HasOne(d => d.IdrolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Idrol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_Rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
