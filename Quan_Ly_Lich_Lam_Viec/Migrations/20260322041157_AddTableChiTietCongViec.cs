using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Lich_Lam_Viec.Migrations
{
    /// <inheritdoc />
    public partial class AddTableChiTietCongViec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chi_Tiet_Cong_Viecs",
                columns: table => new
                {
                    MaChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLich = table.Column<int>(type: "int", nullable: false),
                    TenDauViec = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chi_Tiet_Cong_Viecs", x => x.MaChiTiet);
                    table.ForeignKey(
                        name: "FK_Chi_Tiet_Cong_Viecs_Lich_Lam_Viec_MaLich",
                        column: x => x.MaLich,
                        principalTable: "Lich_Lam_Viec",
                        principalColumn: "MaLich",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chi_Tiet_Cong_Viecs_MaLich",
                table: "Chi_Tiet_Cong_Viecs",
                column: "MaLich");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chi_Tiet_Cong_Viecs");
        }
    }
}
