using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AltHakkimizdas",
                columns: table => new
                {
                    AltHakkimizdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltHakkimizdas", x => x.AltHakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "Bultens",
                columns: table => new
                {
                    BultenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bultens", x => x.BultenID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizda2s",
                columns: table => new
                {
                    Hakkimizda2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslik2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizda2s", x => x.Hakkimizda2ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    HakkimizdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusaitlikDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.HakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IltesimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaritaKonum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IltesimID);
                });

            migrationBuilder.CreateTable(
                name: "OneCikanlar2s",
                columns: table => new
                {
                    OneCikanlar2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneCikanlar2s", x => x.OneCikanlar2ID);
                });

            migrationBuilder.CreateTable(
                name: "OneCikanlars",
                columns: table => new
                {
                    OneCikanlarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneCikanlars", x => x.OneCikanlarID);
                });

            migrationBuilder.CreateTable(
                name: "TatilYerleris",
                columns: table => new
                {
                    OtelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kapasite = table.Column<int>(type: "int", nullable: true),
                    MusaitlikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlaytResmi1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlaytResmi2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlaytResmi3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlaytResmi4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detay1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detay2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TatilYerleris", x => x.OtelID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumlarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Musteri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumlarID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar2s",
                columns: table => new
                {
                    Yorumlar2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorumlar2Kullanıcı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorumlar2Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Yorumlar2Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorumlar2Durum = table.Column<bool>(type: "bit", nullable: false),
                    TatilYerleriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar2s", x => x.Yorumlar2ID);
                    table.ForeignKey(
                        name: "FK_Yorumlar2s_TatilYerleris_TatilYerleriID",
                        column: x => x.TatilYerleriID,
                        principalTable: "TatilYerleris",
                        principalColumn: "OtelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar2s_TatilYerleriID",
                table: "Yorumlar2s",
                column: "TatilYerleriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltHakkimizdas");

            migrationBuilder.DropTable(
                name: "Bultens");

            migrationBuilder.DropTable(
                name: "Hakkimizda2s");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "OneCikanlar2s");

            migrationBuilder.DropTable(
                name: "OneCikanlars");

            migrationBuilder.DropTable(
                name: "Yorumlar2s");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "TatilYerleris");
        }
    }
}
