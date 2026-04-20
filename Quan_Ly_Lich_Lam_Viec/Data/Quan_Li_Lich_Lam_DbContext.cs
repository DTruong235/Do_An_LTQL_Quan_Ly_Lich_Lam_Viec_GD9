using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace Quan_Ly_Lich_Lam_Viec.Data
{
    class Quan_Li_Lich_Lam_DbContext : DbContext
    {
        public DbSet<Nhan_Vien> Nhan_Vien { get; set; }
        public DbSet<Phong_Ban> Phong_Ban { get; set; }
        public DbSet<Chuc_Vu> Chuc_Vu { get; set; }
        public DbSet<Tai_Khoan> Tai_Khoan { get; set; }
        public DbSet<Lich_Su_He_Thong> Lich_Su_He_Thong { get; set; }
        public DbSet<Chi_Tiet_Phan_Cong> Chi_Tiet_Phan_Cong { get; set; }
        public DbSet<Lich_Lam_Viec> Lich_Lam_Viec { get; set; }
        public DbSet<Loai_Cong_Viec> Loai_Cong_Viec { get; set; }
        public DbSet<Dia_Diem> Dia_Diem { get; set; }
        public DbSet<Tien_Do_Cong_Viec> Tien_Do_Cong_Viec { get; set; }
        public virtual DbSet<Chi_Tiet_Cong_Viec> Chi_Tiet_Cong_Viecs { get; set; }
        public DbSet<DonNghiPhep> DonNghiPheps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QuanLyLichLamViec_Connection"].ConnectionString);
        }

        public void CapNhatTienDoTuDong(int maPhanCong)
        {
            using (var db = new Quan_Li_Lich_Lam_DbContext())
            {
                // Lấy thông tin phân công để biết thuộc về Lịch nào

                var phanCongHienTai = db.Chi_Tiet_Phan_Cong.Find(maPhanCong);
                if (phanCongHienTai == null) return;

                var phanCong = db.Chi_Tiet_Phan_Cong.Find(maPhanCong);
                if (phanCong == null) return;

                int maLichCanTinh = phanCongHienTai.MaLich;

                // Tính toán % dựa trên tất cả đầu việc của Lịch đó
                var dsViec = db.Chi_Tiet_Cong_Viecs
                               .Where(t => t.Chi_Tiet_Phan_Cong.MaLich == maLichCanTinh)
                               .ToList();

                if (dsViec.Count == 0) return;

                int soViecXong = dsViec.Count(t => t.TrangThai == true);
                int phanTram = (soViecXong * 100) / dsViec.Count;

                //Tìm bản ghi trong bảng Tien_Do_Cong_Viec để cập nhật
                var tienDo = db.Tien_Do_Cong_Viec.FirstOrDefault(x => x.MaLich == phanCong.MaLich);

                if (tienDo == null)
                {
                    // Nếu chưa có báo cáo thì tạo mới
                    tienDo = new Tien_Do_Cong_Viec
                    {
                        MaLich = phanCong.MaLich,
                        PhanTramHoanThanh = phanTram,
                        NgayCapNhat = DateTime.Now,
                        GhiChu = phanTram == 100 ? "Hoàn thành" : "Đang thực hiện"
                    };
                    db.Tien_Do_Cong_Viec.Add(tienDo);
                }
                else
                {
                    // Nếu có rồi thì cập nhật số liệu mới nhất
                    tienDo.PhanTramHoanThanh = phanTram;
                    tienDo.NgayCapNhat = DateTime.Now;
                }

                db.SaveChanges();
            }
        }

    }
}
