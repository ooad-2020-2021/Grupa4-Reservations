using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NightAlgorithm.Migrations
{
    public partial class prva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dogadjaj",
                columns: table => new
                {
                    idDogađaja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivDogađaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vrijemePočetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipDogađaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opisDogađaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    posebneNapomene = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dobnoOgraničenje = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogadjaj", x => x.idDogađaja);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tekst = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Objekat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kapacitet = table.Column<int>(type: "int", nullable: false),
                    lokacija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrovaniKorisnik",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisničkoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrovaniKorisnik", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vlasnik",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisničkoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnik", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Dogadjaj");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "Objekat");

            migrationBuilder.DropTable(
                name: "RegistrovaniKorisnik");

            migrationBuilder.DropTable(
                name: "Vlasnik");
        }
    }
}
