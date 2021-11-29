using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SistemaDeAlmacen2.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductosAlmacen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Producto = table.Column<string>(type: "text", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Categoria = table.Column<string>(type: "text", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PrecioCompra = table.Column<double>(type: "double precision", nullable: false),
                    PrecioVenta = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosAlmacen", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosAlmacen");
        }
    }
}
