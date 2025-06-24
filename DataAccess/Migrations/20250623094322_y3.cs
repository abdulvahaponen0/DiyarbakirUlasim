using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class y3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HareketSaati",
                table: "hatlars");

            migrationBuilder.AddColumn<int>(
                name: "HareketSaatleriId",
                table: "hatlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "hareketSaatlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HareketSaati = table.Column<TimeSpan>(type: "time", nullable: false),
                    HatlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hareketSaatlers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hareketSaatlers_hatlars_HatlarId",
                        column: x => x.HatlarId,
                        principalTable: "hatlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hareketSaatlers_HatlarId",
                table: "hareketSaatlers",
                column: "HatlarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hareketSaatlers");

            migrationBuilder.DropColumn(
                name: "HareketSaatleriId",
                table: "hatlars");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HareketSaati",
                table: "hatlars",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
