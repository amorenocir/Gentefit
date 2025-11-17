using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gentefit.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDiaYHoraACliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "horario",
                table: "Clase",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<int>(
                name: "dia",
                table: "Clase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "hora",
                table: "Clase",
                type: "time(6)",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dia",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "hora",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "dia",
                table: "Clase");

            migrationBuilder.DropColumn(
                name: "hora",
                table: "Clase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "horario",
                table: "Clase",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
