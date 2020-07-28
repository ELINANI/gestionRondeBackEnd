using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gestionRondeBackEnd.Migrations
{
    public partial class CreatDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    codeAdmin = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomAdmin = table.Column<string>(type: "varchar(150)", nullable: true),
                    prenomAdmin = table.Column<string>(type: "varchar(150)", nullable: true),
                    pawdAdmin = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.codeAdmin);
                });

            migrationBuilder.CreateTable(
                name: "BLEs",
                columns: table => new
                {
                    idBLE = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    heurAjout = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLEs", x => x.idBLE);
                });

            migrationBuilder.CreateTable(
                name: "Plannings",
                columns: table => new
                {
                    codePlanning = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desc = table.Column<string>(type: "varchar(150)", nullable: true),
                    codeAdmin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plannings", x => x.codePlanning);
                    table.ForeignKey(
                        name: "FK_Plannings_Admins_codeAdmin",
                        column: x => x.codeAdmin,
                        principalTable: "Admins",
                        principalColumn: "codeAdmin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    codeAgent = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomAgent = table.Column<string>(type: "varchar(150)", nullable: true),
                    prenomAgent = table.Column<string>(type: "varchar(150)", nullable: true),
                    pawdAgent = table.Column<string>(type: "varchar(150)", nullable: true),
                    codePlanning = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.codeAgent);
                    table.ForeignKey(
                        name: "FK_Agents_Plannings_codePlanning",
                        column: x => x.codePlanning,
                        principalTable: "Plannings",
                        principalColumn: "codePlanning",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traces",
                columns: table => new
                {
                    codeTrace = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idBLE = table.Column<int>(nullable: false),
                    codeAgent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traces", x => x.codeTrace);
                    table.ForeignKey(
                        name: "FK_Traces_Agents_codeAgent",
                        column: x => x.codeAgent,
                        principalTable: "Agents",
                        principalColumn: "codeAgent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Traces_BLEs_idBLE",
                        column: x => x.idBLE,
                        principalTable: "BLEs",
                        principalColumn: "idBLE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_codePlanning",
                table: "Agents",
                column: "codePlanning");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_codeAdmin",
                table: "Plannings",
                column: "codeAdmin");

            migrationBuilder.CreateIndex(
                name: "IX_Traces_codeAgent",
                table: "Traces",
                column: "codeAgent");

            migrationBuilder.CreateIndex(
                name: "IX_Traces_idBLE",
                table: "Traces",
                column: "idBLE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traces");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "BLEs");

            migrationBuilder.DropTable(
                name: "Plannings");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
