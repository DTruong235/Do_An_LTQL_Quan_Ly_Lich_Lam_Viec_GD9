using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Lich_Lam_Viec.Migrations
{
    /// <inheritdoc />
    public partial class MergePermissionToAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tai_Khoan_Phan_Quyen_MaQuyen",
                table: "Tai_Khoan");

            migrationBuilder.DropTable(
                name: "Phan_Quyen");

            migrationBuilder.DropIndex(
                name: "IX_Tai_Khoan_MaQuyen",
                table: "Tai_Khoan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phan_Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phan_Quyen", x => x.MaQuyen);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tai_Khoan_MaQuyen",
                table: "Tai_Khoan",
                column: "MaQuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_Tai_Khoan_Phan_Quyen_MaQuyen",
                table: "Tai_Khoan",
                column: "MaQuyen",
                principalTable: "Phan_Quyen",
                principalColumn: "MaQuyen",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
