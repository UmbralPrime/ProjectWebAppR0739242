using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWebApp.Migrations
{
    public partial class updatedModels1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActiviteitGroepen_Activiteiten_ActiviteitId",
                table: "ActiviteitGroepen");

            migrationBuilder.DropForeignKey(
                name: "FK_ActiviteitGroepen_Groepen_GroepId",
                table: "ActiviteitGroepen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afbeeldingen_Albums_AlbumId",
                table: "Afbeeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_ActiviteitGroepen_ActiviteitGroepId",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtikelGroeps_Artikels_ArtikelId",
                table: "ArtikelGroeps");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtikelGroeps_Groepen_GroepId",
                table: "ArtikelGroeps");

            migrationBuilder.DropForeignKey(
                name: "FK_LidGroeps_Groepen_GroepId",
                table: "LidGroeps");

            migrationBuilder.DropForeignKey(
                name: "FK_LidGroeps_Leden_LidId",
                table: "LidGroeps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LidGroeps",
                table: "LidGroeps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leden",
                table: "Leden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groepen",
                table: "Groepen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artikels",
                table: "Artikels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtikelGroeps",
                table: "ArtikelGroeps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afbeeldingen",
                table: "Afbeeldingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActiviteitGroepen",
                table: "ActiviteitGroepen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activiteiten",
                table: "Activiteiten");

            migrationBuilder.RenameTable(
                name: "LidGroeps",
                newName: "LidGroep");

            migrationBuilder.RenameTable(
                name: "Leden",
                newName: "Lid");

            migrationBuilder.RenameTable(
                name: "Groepen",
                newName: "Groep");

            migrationBuilder.RenameTable(
                name: "Artikels",
                newName: "Artikel");

            migrationBuilder.RenameTable(
                name: "ArtikelGroeps",
                newName: "ArtikelGroep");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album");

            migrationBuilder.RenameTable(
                name: "Afbeeldingen",
                newName: "Afbeelding");

            migrationBuilder.RenameTable(
                name: "ActiviteitGroepen",
                newName: "ActiviteitGroep");

            migrationBuilder.RenameTable(
                name: "Activiteiten",
                newName: "Activiteit");

            migrationBuilder.RenameIndex(
                name: "IX_LidGroeps_LidId",
                table: "LidGroep",
                newName: "IX_LidGroep_LidId");

            migrationBuilder.RenameIndex(
                name: "IX_LidGroeps_GroepId",
                table: "LidGroep",
                newName: "IX_LidGroep_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtikelGroeps_GroepId",
                table: "ArtikelGroep",
                newName: "IX_ArtikelGroep_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtikelGroeps_ArtikelId",
                table: "ArtikelGroep",
                newName: "IX_ArtikelGroep_ArtikelId");

            migrationBuilder.RenameIndex(
                name: "IX_Afbeeldingen_AlbumId",
                table: "Afbeelding",
                newName: "IX_Afbeelding_AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_ActiviteitGroepen_GroepId",
                table: "ActiviteitGroep",
                newName: "IX_ActiviteitGroep_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ActiviteitGroepen_ActiviteitId",
                table: "ActiviteitGroep",
                newName: "IX_ActiviteitGroep_ActiviteitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LidGroep",
                table: "LidGroep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lid",
                table: "Lid",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groep",
                table: "Groep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artikel",
                table: "Artikel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtikelGroep",
                table: "ArtikelGroep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                table: "Album",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afbeelding",
                table: "Afbeelding",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActiviteitGroep",
                table: "ActiviteitGroep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activiteit",
                table: "Activiteit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActiviteitGroep_Activiteit_ActiviteitId",
                table: "ActiviteitGroep",
                column: "ActiviteitId",
                principalTable: "Activiteit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActiviteitGroep_Groep_GroepId",
                table: "ActiviteitGroep",
                column: "GroepId",
                principalTable: "Groep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Afbeelding_Album_AlbumId",
                table: "Afbeelding",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_ActiviteitGroep_ActiviteitGroepId",
                table: "Agendas",
                column: "ActiviteitGroepId",
                principalTable: "ActiviteitGroep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtikelGroep_Artikel_ArtikelId",
                table: "ArtikelGroep",
                column: "ArtikelId",
                principalTable: "Artikel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtikelGroep_Groep_GroepId",
                table: "ArtikelGroep",
                column: "GroepId",
                principalTable: "Groep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LidGroep_Groep_GroepId",
                table: "LidGroep",
                column: "GroepId",
                principalTable: "Groep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LidGroep_Lid_LidId",
                table: "LidGroep",
                column: "LidId",
                principalTable: "Lid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActiviteitGroep_Activiteit_ActiviteitId",
                table: "ActiviteitGroep");

            migrationBuilder.DropForeignKey(
                name: "FK_ActiviteitGroep_Groep_GroepId",
                table: "ActiviteitGroep");

            migrationBuilder.DropForeignKey(
                name: "FK_Afbeelding_Album_AlbumId",
                table: "Afbeelding");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_ActiviteitGroep_ActiviteitGroepId",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtikelGroep_Artikel_ArtikelId",
                table: "ArtikelGroep");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtikelGroep_Groep_GroepId",
                table: "ArtikelGroep");

            migrationBuilder.DropForeignKey(
                name: "FK_LidGroep_Groep_GroepId",
                table: "LidGroep");

            migrationBuilder.DropForeignKey(
                name: "FK_LidGroep_Lid_LidId",
                table: "LidGroep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LidGroep",
                table: "LidGroep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lid",
                table: "Lid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groep",
                table: "Groep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtikelGroep",
                table: "ArtikelGroep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artikel",
                table: "Artikel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                table: "Album");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afbeelding",
                table: "Afbeelding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActiviteitGroep",
                table: "ActiviteitGroep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activiteit",
                table: "Activiteit");

            migrationBuilder.RenameTable(
                name: "LidGroep",
                newName: "LidGroeps");

            migrationBuilder.RenameTable(
                name: "Lid",
                newName: "Leden");

            migrationBuilder.RenameTable(
                name: "Groep",
                newName: "Groepen");

            migrationBuilder.RenameTable(
                name: "ArtikelGroep",
                newName: "ArtikelGroeps");

            migrationBuilder.RenameTable(
                name: "Artikel",
                newName: "Artikels");

            migrationBuilder.RenameTable(
                name: "Album",
                newName: "Albums");

            migrationBuilder.RenameTable(
                name: "Afbeelding",
                newName: "Afbeeldingen");

            migrationBuilder.RenameTable(
                name: "ActiviteitGroep",
                newName: "ActiviteitGroepen");

            migrationBuilder.RenameTable(
                name: "Activiteit",
                newName: "Activiteiten");

            migrationBuilder.RenameIndex(
                name: "IX_LidGroep_LidId",
                table: "LidGroeps",
                newName: "IX_LidGroeps_LidId");

            migrationBuilder.RenameIndex(
                name: "IX_LidGroep_GroepId",
                table: "LidGroeps",
                newName: "IX_LidGroeps_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtikelGroep_GroepId",
                table: "ArtikelGroeps",
                newName: "IX_ArtikelGroeps_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtikelGroep_ArtikelId",
                table: "ArtikelGroeps",
                newName: "IX_ArtikelGroeps_ArtikelId");

            migrationBuilder.RenameIndex(
                name: "IX_Afbeelding_AlbumId",
                table: "Afbeeldingen",
                newName: "IX_Afbeeldingen_AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_ActiviteitGroep_GroepId",
                table: "ActiviteitGroepen",
                newName: "IX_ActiviteitGroepen_GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_ActiviteitGroep_ActiviteitId",
                table: "ActiviteitGroepen",
                newName: "IX_ActiviteitGroepen_ActiviteitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LidGroeps",
                table: "LidGroeps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leden",
                table: "Leden",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groepen",
                table: "Groepen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtikelGroeps",
                table: "ArtikelGroeps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artikels",
                table: "Artikels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afbeeldingen",
                table: "Afbeeldingen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActiviteitGroepen",
                table: "ActiviteitGroepen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activiteiten",
                table: "Activiteiten",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActiviteitGroepen_Activiteiten_ActiviteitId",
                table: "ActiviteitGroepen",
                column: "ActiviteitId",
                principalTable: "Activiteiten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActiviteitGroepen_Groepen_GroepId",
                table: "ActiviteitGroepen",
                column: "GroepId",
                principalTable: "Groepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Afbeeldingen_Albums_AlbumId",
                table: "Afbeeldingen",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_ActiviteitGroepen_ActiviteitGroepId",
                table: "Agendas",
                column: "ActiviteitGroepId",
                principalTable: "ActiviteitGroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtikelGroeps_Artikels_ArtikelId",
                table: "ArtikelGroeps",
                column: "ArtikelId",
                principalTable: "Artikels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtikelGroeps_Groepen_GroepId",
                table: "ArtikelGroeps",
                column: "GroepId",
                principalTable: "Groepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LidGroeps_Groepen_GroepId",
                table: "LidGroeps",
                column: "GroepId",
                principalTable: "Groepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LidGroeps_Leden_LidId",
                table: "LidGroeps",
                column: "LidId",
                principalTable: "Leden",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
