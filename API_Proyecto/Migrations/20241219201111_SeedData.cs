using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Proyecto.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insertar datos en Tamanios
            migrationBuilder.InsertData(
                table: "Tamanios",
                columns: new[] { "Id", "alto", "ancho", "profundidad" },
                values: new object[,]
                {
                    { 1, 30, 20, 15 },
                    { 2, 50, 40, 25 }
                });

            // Insertar datos en Productos
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Descripcion", "TamanioId" },
                values: new object[,]
                {
                    { 1, "Producto A", 1 },
                    { 2, "Producto B", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Eliminar datos en Productos
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValues: new object[] { 1, 2 });

            // Eliminar datos en Tamanios
            migrationBuilder.DeleteData(
                table: "Tamanios",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2 });
        }
    }
}
