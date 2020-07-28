using Microsoft.EntityFrameworkCore.Migrations;

namespace gestionRondeBackEnd.Migrations
{
    public partial class jota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces");

            migrationBuilder.DropIndex(
                name: "IX_Traces_idBLE",
                table: "Traces");

            migrationBuilder.DropColumn(
                name: "idBLE",
                table: "Traces");

            migrationBuilder.AddColumn<string>(
                name: "wifiName",
                table: "Traces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "wifiName",
                table: "Traces");

            migrationBuilder.AddColumn<string>(
                name: "idBLE",
                table: "Traces",
                type: "varchar(150)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Traces_idBLE",
                table: "Traces",
                column: "idBLE");

            migrationBuilder.AddForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces",
                column: "idBLE",
                principalTable: "BLEs",
                principalColumn: "idBLE",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
