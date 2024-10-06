using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class ControlarNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 10, 22, 308, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 10, 4, 0, 10, 22, 308, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 10, 22, 308, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 10, 4, 0, 10, 22, 308, DateTimeKind.Local).AddTicks(8111) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 11, 5, 699, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 9, 28, 18, 11, 5, 699, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 11, 5, 699, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 9, 28, 18, 11, 5, 699, DateTimeKind.Local).AddTicks(4807) });
        }
    }
}
