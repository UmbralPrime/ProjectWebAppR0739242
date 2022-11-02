using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activiteiten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activiteiten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artikels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inhoud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groepen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groepen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOuder = table.Column<bool>(type: "bit", nullable: false),
                    Betaald = table.Column<bool>(type: "bit", nullable: false),
                    Telefoon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Afbeeldingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    linkAfbeelding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afbeeldingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afbeeldingen_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActiviteitGroepen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActiviteitId = table.Column<int>(type: "int", nullable: false),
                    GroepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiviteitGroepen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiviteitGroepen_Activiteiten_ActiviteitId",
                        column: x => x.ActiviteitId,
                        principalTable: "Activiteiten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActiviteitGroepen_Groepen_GroepId",
                        column: x => x.GroepId,
                        principalTable: "Groepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtikelGroeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroepId = table.Column<int>(type: "int", nullable: false),
                    ArtikelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtikelGroeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtikelGroeps_Artikels_ArtikelId",
                        column: x => x.ArtikelId,
                        principalTable: "Artikels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtikelGroeps_Groepen_GroepId",
                        column: x => x.GroepId,
                        principalTable: "Groepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LidGroeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LidId = table.Column<int>(type: "int", nullable: false),
                    GroepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LidGroeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LidGroeps_Groepen_GroepId",
                        column: x => x.GroepId,
                        principalTable: "Groepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LidGroeps_Leden_LidId",
                        column: x => x.LidId,
                        principalTable: "Leden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiviteitGroepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_ActiviteitGroepen_ActiviteitGroepId",
                        column: x => x.ActiviteitGroepId,
                        principalTable: "ActiviteitGroepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiviteitGroepen_ActiviteitId",
                table: "ActiviteitGroepen",
                column: "ActiviteitId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiviteitGroepen_GroepId",
                table: "ActiviteitGroepen",
                column: "GroepId");

            migrationBuilder.CreateIndex(
                name: "IX_Afbeeldingen_AlbumId",
                table: "Afbeeldingen",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_ActiviteitGroepId",
                table: "Agendas",
                column: "ActiviteitGroepId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtikelGroeps_ArtikelId",
                table: "ArtikelGroeps",
                column: "ArtikelId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtikelGroeps_GroepId",
                table: "ArtikelGroeps",
                column: "GroepId");

            migrationBuilder.CreateIndex(
                name: "IX_LidGroeps_GroepId",
                table: "LidGroeps",
                column: "GroepId");

            migrationBuilder.CreateIndex(
                name: "IX_LidGroeps_LidId",
                table: "LidGroeps",
                column: "LidId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afbeeldingen");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "ArtikelGroeps");

            migrationBuilder.DropTable(
                name: "LidGroeps");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "ActiviteitGroepen");

            migrationBuilder.DropTable(
                name: "Artikels");

            migrationBuilder.DropTable(
                name: "Leden");

            migrationBuilder.DropTable(
                name: "Activiteiten");

            migrationBuilder.DropTable(
                name: "Groepen");
        }
    }
}
