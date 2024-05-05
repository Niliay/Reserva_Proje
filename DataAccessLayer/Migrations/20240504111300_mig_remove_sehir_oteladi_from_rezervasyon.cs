using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_remove_sehir_oteladi_from_rezervasyon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtelAdi",
                table: "Rezervasyons");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Rezervasyons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtelAdi",
                table: "Rezervasyons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Rezervasyons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
