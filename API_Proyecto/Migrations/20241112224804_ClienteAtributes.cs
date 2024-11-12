using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Proyecto.Migrations
{
    /// <inheritdoc />
    public partial class ClienteAtributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteCUIT",
                table: "Posiciones",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apynom",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RazonSocial",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Posiciones_ClienteCUIT",
                table: "Posiciones",
                column: "ClienteCUIT");

            migrationBuilder.AddForeignKey(
                name: "FK_Posiciones_Clientes_ClienteCUIT",
                table: "Posiciones",
                column: "ClienteCUIT",
                principalTable: "Clientes",
                principalColumn: "CUIT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posiciones_Clientes_ClienteCUIT",
                table: "Posiciones");

            migrationBuilder.DropIndex(
                name: "IX_Posiciones_ClienteCUIT",
                table: "Posiciones");

            migrationBuilder.DropColumn(
                name: "ClienteCUIT",
                table: "Posiciones");

            migrationBuilder.DropColumn(
                name: "Apynom",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RazonSocial",
                table: "Clientes");
        }
    }
}
