using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Lich_Lam_Viec.Migrations
{
    /// <inheritdoc />
    public partial class RenameLyDoToGhiChu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LyDoTreHan",
                table: "Tien_Do_Cong_Viec",
                newName: "GhiChu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GhiChu",
                table: "Tien_Do_Cong_Viec",
                newName: "LyDoTreHan");
        }
    }
}
