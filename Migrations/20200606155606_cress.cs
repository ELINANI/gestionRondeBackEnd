using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gestionRondeBackEnd.Migrations
{
    public partial class cress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Plannings_codePlanning",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Plannings_Admins_codeAdmin",
                table: "Plannings");

            migrationBuilder.DropForeignKey(
                name: "FK_Traces_Agents_codeAgent",
                table: "Traces");

            migrationBuilder.DropForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces");

            migrationBuilder.AlterColumn<string>(
                name: "idBLE",
                table: "Traces",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "codeAgent",
                table: "Traces",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "codeTrace",
                table: "Traces",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "codeAdmin",
                table: "Plannings",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "codePlanning",
                table: "Plannings",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "idBLE",
                table: "BLEs",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "codePlanning",
                table: "Agents",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "codeAgent",
                table: "Agents",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "codeAdmin",
                table: "Admins",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Plannings_codePlanning",
                table: "Agents",
                column: "codePlanning",
                principalTable: "Plannings",
                principalColumn: "codePlanning",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plannings_Admins_codeAdmin",
                table: "Plannings",
                column: "codeAdmin",
                principalTable: "Admins",
                principalColumn: "codeAdmin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traces_Agents_codeAgent",
                table: "Traces",
                column: "codeAgent",
                principalTable: "Agents",
                principalColumn: "codeAgent",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces",
                column: "idBLE",
                principalTable: "BLEs",
                principalColumn: "idBLE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Plannings_codePlanning",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Plannings_Admins_codeAdmin",
                table: "Plannings");

            migrationBuilder.DropForeignKey(
                name: "FK_Traces_Agents_codeAgent",
                table: "Traces");

            migrationBuilder.DropForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces");

            migrationBuilder.AlterColumn<int>(
                name: "idBLE",
                table: "Traces",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "codeAgent",
                table: "Traces",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "codeTrace",
                table: "Traces",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "codeAdmin",
                table: "Plannings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "codePlanning",
                table: "Plannings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "idBLE",
                table: "BLEs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "codePlanning",
                table: "Agents",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "codeAgent",
                table: "Agents",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "codeAdmin",
                table: "Admins",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Plannings_codePlanning",
                table: "Agents",
                column: "codePlanning",
                principalTable: "Plannings",
                principalColumn: "codePlanning",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plannings_Admins_codeAdmin",
                table: "Plannings",
                column: "codeAdmin",
                principalTable: "Admins",
                principalColumn: "codeAdmin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traces_Agents_codeAgent",
                table: "Traces",
                column: "codeAgent",
                principalTable: "Agents",
                principalColumn: "codeAgent",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traces_BLEs_idBLE",
                table: "Traces",
                column: "idBLE",
                principalTable: "BLEs",
                principalColumn: "idBLE",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
