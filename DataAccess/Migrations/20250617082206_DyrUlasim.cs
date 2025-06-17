using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DyrUlasim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "yolcus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoyAd = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    KullanıcıKodu = table.Column<int>(type: "int", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Bakiye = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yolcus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gecmisBankaIslemleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bakiye = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KartNumarasi = table.Column<int>(type: "int", nullable: false),
                    YolcuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gecmisBankaIslemleris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gecmisBankaIslemleris_yolcus_YolcuId",
                        column: x => x.YolcuId,
                        principalTable: "yolcus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "krediKartis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KartSahibi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KartNumarasi = table.Column<int>(type: "int", maxLength: 16, nullable: false),
                    SonKullanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuvenlikKodu = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: true),
                    YolcuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_krediKartis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_krediKartis_yolcus_YolcuId",
                        column: x => x.YolcuId,
                        principalTable: "yolcus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_gecmisBankaIslemleris_YolcuId",
                table: "gecmisBankaIslemleris",
                column: "YolcuId");

            migrationBuilder.CreateIndex(
                name: "IX_krediKartis_YolcuId",
                table: "krediKartis",
                column: "YolcuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gecmisBankaIslemleris");

            migrationBuilder.DropTable(
                name: "krediKartis");

            migrationBuilder.DropTable(
                name: "yolcus");
        }
    }
}
