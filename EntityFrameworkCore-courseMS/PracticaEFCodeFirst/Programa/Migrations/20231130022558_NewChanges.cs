using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa.Migrations
{
    public partial class NewChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrabajoIdTrabajo",
                table: "trabajos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_trabajos_TrabajoIdTrabajo",
                table: "trabajos",
                column: "TrabajoIdTrabajo");

            migrationBuilder.AddForeignKey(
                name: "FK_trabajos_trabajos_TrabajoIdTrabajo",
                table: "trabajos",
                column: "TrabajoIdTrabajo",
                principalTable: "trabajos",
                principalColumn: "IdTrabajo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trabajos_trabajos_TrabajoIdTrabajo",
                table: "trabajos");

            migrationBuilder.DropIndex(
                name: "IX_trabajos_TrabajoIdTrabajo",
                table: "trabajos");

            migrationBuilder.DropColumn(
                name: "TrabajoIdTrabajo",
                table: "trabajos");
        }
    }
}
