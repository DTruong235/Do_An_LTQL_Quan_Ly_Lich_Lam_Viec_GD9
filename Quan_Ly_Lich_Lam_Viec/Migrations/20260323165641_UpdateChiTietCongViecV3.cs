using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Lich_Lam_Viec.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChiTietCongViecV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chi_Tiet_Cong_Viecs_Lich_Lam_Viec_MaLich",
                table: "Chi_Tiet_Cong_Viecs");

            migrationBuilder.DropIndex(
                name: "IX_Chi_Tiet_Cong_Viecs_MaLich",
                table: "Chi_Tiet_Cong_Viecs");

            migrationBuilder.AddColumn<int>(
                name: "MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chi_Tiet_Cong_Viecs_MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs",
                column: "MaPhanCong");

            migrationBuilder.AddForeignKey(
                name: "FK_Chi_Tiet_Cong_Viecs_Chi_Tiet_Phan_Cong_MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs",
                column: "MaPhanCong",
                principalTable: "Chi_Tiet_Phan_Cong",
                principalColumn: "MaPhanCong",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chi_Tiet_Cong_Viecs_Chi_Tiet_Phan_Cong_MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs");

            migrationBuilder.DropIndex(
                name: "IX_Chi_Tiet_Cong_Viecs_MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs");

            migrationBuilder.DropColumn(
                name: "MaPhanCong",
                table: "Chi_Tiet_Cong_Viecs");

            migrationBuilder.CreateIndex(
                name: "IX_Chi_Tiet_Cong_Viecs_MaLich",
                table: "Chi_Tiet_Cong_Viecs",
                column: "MaLich");

            migrationBuilder.AddForeignKey(
                name: "FK_Chi_Tiet_Cong_Viecs_Lich_Lam_Viec_MaLich",
                table: "Chi_Tiet_Cong_Viecs",
                column: "MaLich",
                principalTable: "Lich_Lam_Viec",
                principalColumn: "MaLich",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
