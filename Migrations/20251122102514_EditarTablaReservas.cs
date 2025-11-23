using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gentefit.Migrations
{
    /// <inheritdoc />
    public partial class EditarTablaReservas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dia",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "hora",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Reserva",
                newName: "fechaReserva");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaClase",
                table: "Reserva",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaClase",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "fechaReserva",
                table: "Reserva",
                newName: "fecha");

            migrationBuilder.AddColumn<int>(
                name: "dia",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "hora",
                table: "Reserva",
                type: "time(6)",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}
