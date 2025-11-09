using System;
using System.Collections.Generic;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Microsoft.EntityFrameworkCore;

namespace Gentefit.db;

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


    public virtual DbSet<Gentefit.Modelo.Entrenador> Monitors { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=gentefitdb;user=root;password=1234", new MySqlServerVersion(new Version(8,0, 36)));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.idActividad).HasName("PK__Activida__3214EC27DEE2385C");

            entity.ToTable("Actividad");

            entity.Property(e => e.idActividad).HasColumnName("ID");
            entity.Property(e => e.descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.intensidad)
                .HasConversion<int>()  // Guardar enum como INT
                .HasColumnName("Intensidad");
            entity.Property(e => e.nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.HasKey(e => e.idClase).HasName("PK__Clase__3214EC272040217E");

            entity.ToTable("Clase");

            entity.Property(e => e.idClase).HasColumnName("ID");
            entity.Property(e => e.horario).HasColumnType("datetime");

        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.idCliente).HasName("PK__Cliente__3214EC2768363A56");

            entity.ToTable("Cliente");

            entity.Property(e => e.idCliente).HasColumnName("ID");
            entity.Property(e => e.apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.contrasena)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gentefit.Modelo.Entrenador>(entity =>
        {
            entity.HasKey(e => e.idEntrenador).HasName("PK__Monitor__3214EC272BF7700F");

            entity.ToTable("Monitor");

            entity.Property(e => e.idEntrenador).HasColumnName("ID");
            entity.Property(e => e.apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.idReserva).HasName("PK__Reserva__3214EC279A26C7E9");

            entity.ToTable("Reserva");

            entity.Property(e => e.idReserva).HasColumnName("ID");

            entity.Property(e => e.estado)
                .HasConversion<int>() // Guarda el enum como int
                .HasColumnName("Estado");

            entity.Property(e => e.fecha)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(r => r.cliente)
                .WithMany(c => c.listaReservas)
                .HasForeignKey(r => r.idCliente)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(r => r.clase)
                .WithMany(c => c.reservas)
                .HasForeignKey(r => r.idClase)
                .OnDelete(DeleteBehavior.Cascade);

        });


        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.idSala).HasName("PK__Sala__3214EC270728BC4D");

            entity.ToTable("Sala");

            entity.Property(e => e.idSala).HasColumnName("ID"); 
            entity.Property(e => e.nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.idUsuario).HasName("PK__Usuario__3214EC2704BBB9A4");

            entity.ToTable("Usuario");

            entity.Property(e => e.idUsuario).HasColumnName("ID");
            entity.Property(e => e.apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.contrasena)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.rol)
                .HasConversion<int>() // Guarda el enum como int
                .HasColumnName("IdRol");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
