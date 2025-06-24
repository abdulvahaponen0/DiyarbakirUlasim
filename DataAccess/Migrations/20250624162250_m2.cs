using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YolcuId",
                table: "ıletisims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ıletisims_YolcuId",
                table: "ıletisims",
                column: "YolcuId");

            migrationBuilder.AddForeignKey(
                name: "FK_ıletisims_yolcus_YolcuId",
                table: "ıletisims",
                column: "YolcuId",
                principalTable: "yolcus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ıletisims_yolcus_YolcuId",
                table: "ıletisims");

            migrationBuilder.DropIndex(
                name: "IX_ıletisims_YolcuId",
                table: "ıletisims");

            migrationBuilder.DropColumn(
                name: "YolcuId",
                table: "ıletisims");
        }
    }
}
