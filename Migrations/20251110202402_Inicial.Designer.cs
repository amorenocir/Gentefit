
using System;
using Gentefit.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gentefit.Migrations
{
    [DbContext(typeof(GentefitContext))]

    [Migration("20251110202402_Inicial")]
    partial class Inicial { }

    [Migration("20251110154121_David")]
    partial class David

    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Gentefit.Modelo.Actividad", b =>
                {
                    b.Property<int>("idActividad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idActividad"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int>("intensidad")
                        .HasColumnType("int")
                        .HasColumnName("Intensidad");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("idActividad")
                        .HasName("PK__Activida__3214EC27DEE2385C");

                    b.ToTable("Actividad", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Clase", b =>
                {
                    b.Property<int>("idClase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idClase"));

                    b.Property<DateTime>("horario")
                        .HasColumnType("datetime");

                    b.Property<int>("idActividad")
                        .HasColumnType("int")
                        .HasColumnName("id_actividad");

                    b.Property<int>("idEntrenador")
                        .HasColumnType("int")
                        .HasColumnName("id_entrenador");

                    b.Property<int>("idSala")
                        .HasColumnType("int")
                        .HasColumnName("id_sala");

                    b.Property<int>("plazasLibres")
                        .HasColumnType("int");

                    b.HasKey("idClase")
                        .HasName("PK__Clase__3214EC272040217E");

                    b.HasIndex("idActividad");

                    b.HasIndex("idEntrenador");

                    b.HasIndex("idSala");

                    b.ToTable("Clase", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("DNI");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("telefono")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("idCliente")
                        .HasName("PK__Cliente__3214EC2768363A56");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Entrenador", b =>
                {
                    b.Property<int>("idEntrenador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idEntrenador"));

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("DNI");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("idEntrenador")
                        .HasName("PK__Monitor__3214EC272BF7700F");

                    b.ToTable("Entrenador", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Reserva", b =>
                {
                    b.Property<int>("idReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idReserva"));

                    b.Property<int>("estado")
                        .HasColumnType("int")
                        .HasColumnName("Estado");

                    b.Property<DateTime>("fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("idClase")
                        .HasColumnType("int")
                        .HasColumnName("id_clase");

                    b.Property<int>("idCliente")
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    b.HasKey("idReserva")
                        .HasName("PK__Reserva__3214EC279A26C7E9");

                    b.HasIndex("idClase");

                    b.HasIndex("idCliente");

                    b.ToTable("Reserva", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Sala", b =>
                {
                    b.Property<int>("idSala")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idSala"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("idSala")
                        .HasName("PK__Sala__3214EC270728BC4D");

                    b.ToTable("Sala", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("rol")
                        .HasColumnType("int")
                        .HasColumnName("IdRol");

                    b.HasKey("idUsuario")
                        .HasName("PK__Usuario__3214EC2704BBB9A4");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Gentefit.Modelo.Clase", b =>
                {
                    b.HasOne("Gentefit.Modelo.Actividad", "actividad")
                        .WithMany("listaClases")
                        .HasForeignKey("idActividad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gentefit.Modelo.Entrenador", "entrenador")
                        .WithMany("listaClases")
                        .HasForeignKey("idEntrenador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gentefit.Modelo.Sala", "sala")
                        .WithMany("listaClases")
                        .HasForeignKey("idSala")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("actividad");

                    b.Navigation("entrenador");

                    b.Navigation("sala");
                });

            modelBuilder.Entity("Gentefit.Modelo.Reserva", b =>
                {
                    b.HasOne("Gentefit.Modelo.Clase", "clase")
                        .WithMany("reservas")
                        .HasForeignKey("idClase")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gentefit.Modelo.Cliente", "cliente")
                        .WithMany("listaReservas")
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clase");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Gentefit.Modelo.Actividad", b =>
                {
                    b.Navigation("listaClases");
                });

            modelBuilder.Entity("Gentefit.Modelo.Clase", b =>
                {
                    b.Navigation("reservas");
                });

            modelBuilder.Entity("Gentefit.Modelo.Cliente", b =>
                {
                    b.Navigation("listaReservas");
                });

            modelBuilder.Entity("Gentefit.Modelo.Entrenador", b =>
                {
                    b.Navigation("listaClases");
                });

            modelBuilder.Entity("Gentefit.Modelo.Sala", b =>
                {
                    b.Navigation("listaClases");
                });
#pragma warning restore 612, 618
        }
    }
}
