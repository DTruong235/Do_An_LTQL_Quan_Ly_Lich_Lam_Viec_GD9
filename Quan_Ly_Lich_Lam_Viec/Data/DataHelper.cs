using Microsoft.EntityFrameworkCore;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    static class DataHelper
    {
        public static IQueryable<T> FilterByRole<T>(IQueryable<T> query, string memberName = "MaNhanVien") where T : class
        {
            //Nếu chưa đăng nhập hoặc là Quản lý (MaQuyen == 1) -> Trả về toàn bộ
            if (Program.CurrentUser == null || Program.CurrentUser.MaQuyen == 1)
            {
                return query;
            }

            //Nếu là Nhân viên (MaQuyen == 0) -> Lọc theo mã nhân viên đang đăng nhập
            int currentUserId = Program.CurrentUser.MaNhanVien;

            // Dùng LINQ động để lọc theo thuộc tính MaNhanVien
            return query.Where(item => EF.Property<int>(item, memberName) == currentUserId);
        }


        public static void CapNhatTienDoTuDong(int maLich, Quan_Li_Lich_Lam_DbContext db)
        {

            var tatCaViec = db.Chi_Tiet_Cong_Viecs.Where(v => v.MaLich == maLich).ToList();

            if (tatCaViec.Count > 0)
            {
                int phanTram = (tatCaViec.Count(v => v.TrangThai == true) * 100) / tatCaViec.Count;

                var tienDo = db.Tien_Do_Cong_Viec.FirstOrDefault(t => t.MaLich == maLich);
                if (tienDo == null)
                {
                    db.Tien_Do_Cong_Viec.Add(new Tien_Do_Cong_Viec
                    {
                        MaLich = maLich,
                        PhanTramHoanThanh = phanTram,
                        NgayCapNhat = DateTime.Now,
                        GhiChu = "Cập nhật từ Import"
                    });
                }
                else
                {
                    tienDo.PhanTramHoanThanh = phanTram;
                    tienDo.NgayCapNhat = DateTime.Now;
                }
                db.SaveChanges(); // Lưu vào bộ nhớ đệm của transaction
            }
        }

        public static void WriteLog(string hanhDong, string chiTiet)
        {
            try
            {
                using (var db = new Quan_Li_Lich_Lam_DbContext())
                {
                    var log = new Lich_Su_He_Thong
                    {
                        // Lấy ID nhân viên từ Program.CurrentUser (đã đăng nhập)
                        MaNhanVien = Program.CurrentUser?.MaNhanVien,
                        HanhDong = hanhDong,
                        ChiTiet = chiTiet,
                        ThoiGian = DateTime.Now
                    };
                    db.Lich_Su_He_Thong.Add(log);
                    db.SaveChanges(); // Lưu vào bảng Lich_Su_He_Thong
                }
            }
            catch
            {
                // Ghi log lỗi không nên làm dừng chương trình chính
            }
        }
    }
}
