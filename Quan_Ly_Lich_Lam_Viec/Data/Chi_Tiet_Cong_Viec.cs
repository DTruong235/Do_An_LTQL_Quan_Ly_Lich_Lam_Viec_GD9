using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    class Chi_Tiet_Cong_Viec
    {
        [Key]
        public int MaChiTiet { get; set; }

        public int MaPhanCong { get; set; } // Khóa ngoại mới

        public int MaLich { get; set; }

        [Required]
        [StringLength(255)]
        public string TenDauViec { get; set; }

        public bool TrangThai { get; set; }


        [ForeignKey("MaPhanCong")]
        public virtual Chi_Tiet_Phan_Cong Chi_Tiet_Phan_Cong { get; set; }
    }
}

