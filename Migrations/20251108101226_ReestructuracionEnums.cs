using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gentefit.Migrations
{
    public partial class ReestructuracionEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Renombrar columnas
            migrationBuilder.RenameColumn(
                name: "IDRol",
                table: "Usuario",
                newName: "IdRol");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Reserva",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "intensidad",
                table: "Actividad",
                newName: "Intensidad");

            // Modificar tipo de columna fecha
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Reserva",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP(6)",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            // Modificar columna intensidad a int (enum)
            migrationBuilder.AlterColumn<int>(
                name: "Intensidad",
                table: "Actividad",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revertir nombres de columnas
            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Usuario",
                newName: "IDRol");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Reserva",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Intensidad",
                table: "Actividad",
                newName: "intensidad");

            // Revertir tipo fecha
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Reserva",
                type: "datetime",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "CURRENT_TIMESTAMP(6)");

            // Revertir intensidad a string
            migrationBuilder.AlterColumn<string>(
                name: "intensidad",
                table: "Actividad",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

