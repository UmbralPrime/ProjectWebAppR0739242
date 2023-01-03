using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWebApp.Migrations
{
    public partial class updateupdategroep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LidGroep");

            migrationBuilder.AddColumn<int>(
                name: "GroepId",
                table: "Lid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lid_GroepId",
                table: "Lid",
                column: "GroepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lid_Groep_GroepId",
                table: "Lid",
                column: "GroepId",
                principalTable: "Groep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lid_Groep_GroepId",
                table: "Lid");

            migrationBuilder.DropIndex(
                name: "IX_Lid_GroepId",
                table: "Lid");

            migrationBuilder.DropColumn(
                name: "GroepId",
                table: "Lid");

            migrationBuilder.CreateTable(
                name: "LidGroep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroepId = table.Column<int>(type: "int", nullable: false),
                    LidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LidGroep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LidGroep_Groep_GroepId",
                        column: x => x.GroepId,
                        principalTable: "Groep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LidGroep_Lid_LidId",
                        column: x => x.LidId,
                        principalTable: "Lid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LidGroep_GroepId",
                table: "LidGroep",
                column: "GroepId");

            migrationBuilder.CreateIndex(
                name: "IX_LidGroep_LidId",
                table: "LidGroep",
                column: "LidId");
        }
    }
}
