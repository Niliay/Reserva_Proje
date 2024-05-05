using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_rezervasyon_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervasyons",
                columns: table => new
                {
                    ReservasyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    KisiSayisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezervayonTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RezervasyonDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TatilYerleriOtelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyons", x => x.ReservasyonID);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_TatilYerleris_TatilYerleriOtelID",
                        column: x => x.TatilYerleriOtelID,
                        principalTable: "TatilYerleris",
                        principalColumn: "OtelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_AppUserID",
                table: "Rezervasyons",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_TatilYerleriOtelID",
                table: "Rezervasyons",
                column: "TatilYerleriOtelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervasyons");
        }
    }
}
