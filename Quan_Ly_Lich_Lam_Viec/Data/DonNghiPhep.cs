using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    class DonNghiPhep
    {
        public int Id { get; set; }

        public int MaNhanVien { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public string LyDo { get; set; }

        public int TrangThai { get; set; } // 0: Chờ, 1: Duyệt, 2: Từ chối

        [ForeignKey("MaNhanVien")]
        public virtual Nhan_Vien Nhan_Vien { get; set; }
    }
}
