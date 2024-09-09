using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace proyectoef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CAtegoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "CAtegoria",
                columns: new[] { "CategorioaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c02"), null, "Actividades personales", 50 },
                    { new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904ccc"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c10"), new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904ccc"), null, new DateTime(2024, 9, 3, 20, 37, 18, 264, DateTimeKind.Local).AddTicks(6757), 1, "Pago de servicios publicos" },
                    { new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c11"), new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c02"), null, new DateTime(2024, 9, 3, 20, 37, 18, 264, DateTimeKind.Local).AddTicks(6790), 0, "Terminar de ver pelicula en netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c10"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c11"));

            migrationBuilder.DeleteData(
                table: "CAtegoria",
                keyColumn: "CategorioaId",
                keyValue: new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904c02"));

            migrationBuilder.DeleteData(
                table: "CAtegoria",
                keyColumn: "CategorioaId",
                keyValue: new Guid("3a08a698-55a5-44a9-a6c8-d4a7c3904ccc"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CAtegoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
