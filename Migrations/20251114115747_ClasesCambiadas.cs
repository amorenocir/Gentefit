using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gentefit.Migrations
{
    /// <inheritdoc />
    public partial class ClasesCambiadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enEspera",
                table: "Clase");

            migrationBuilder.DropColumn(
                name: "horario",
                table: "Clase");

            migrationBuilder.RenameColumn(
                name: "plazasLibres",
                table: "Clase",
                newName: "dia");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "hora",
                table: "Clase",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hora",
                table: "Clase");

            migrationBuilder.RenameColumn(
                name: "dia",
                table: "Clase",
                newName: "plazasLibres");

            migrationBuilder.AddColumn<int>(
                name: "enEspera",
                table: "Clase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "horario",
                table: "Clase",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
