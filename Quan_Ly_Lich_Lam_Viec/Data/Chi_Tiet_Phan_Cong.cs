using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Chi_Tiet_Phan_Cong")]
    class Chi_Tiet_Phan_Cong
    {
        [Key]
        public int MaPhanCong { get; set; }

        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual Nhan_Vien Nhan_Vien { get; set; }

        public int MaLich { get; set; }
        [ForeignKey("MaLich")]
        public virtual Lich_Lam_Viec Lich_Lam_Viec { get; set; }

        public string Vai_Tro { get; set; }
        public bool Da_Xac_Nhan { get; set; }
        public string GiaoViec
        {
            get
            {
                // Kiểm tra danh sách phân công
                if (Chi_Tiet_Cong_Viec == null || Chi_Tiet_Cong_Viec.Count == 0)
                {
                    return "Thêm chi tiết công việc"; // Giá trị mặc định cho lịch mới
                }
                return $"Xem chi tiết công việc"; // Cập nhật khi có dữ liệu
            }
        }

        // Một sự phân công (Nhân viên A - Lịch B) sẽ có nhiều đầu việc
        public virtual ICollection<Chi_Tiet_Cong_Viec> Chi_Tiet_Cong_Viec { get; set; }
    }
}
