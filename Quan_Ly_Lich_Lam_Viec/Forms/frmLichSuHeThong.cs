using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmLichSuHeThong : frmBase
    {

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        public frmLichSuHeThong()
        {
            InitializeComponent();
        }

        private void frmLichSuHeThong_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            using (var db = new Quan_Li_Lich_Lam_DbContext())
            {
                // Lấy danh sách nhân viên, thêm một lựa chọn "Tất cả" ở đầu cho linh hoạt
                var dsNhanVien = db.Nhan_Vien
                                   .Select(nv => new { nv.MaNhanVien, nv.HoTen })
                                   .ToList();

                // Chèn thêm option "Tất cả nhân viên" với mã là -1
                dsNhanVien.Insert(0, new { MaNhanVien = -1, HoTen = "--- Tất cả nhân viên ---" });

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNhanVien";
            }
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                // Truy vấn dữ liệu lịch sử
                var query = context.Lich_Su_He_Thong
                    .Include(l => l.Nhan_Vien) // Nạp dữ liệu bảng Nhân viên liên kết
                    .OrderByDescending(l => l.ThoiGian) // Mới nhất hiện lên đầu
                    .Select(l => new
                    {
                        MaNhanVien = l.MaNhanVien,
                        HanhDong = l.HanhDong,
                        ChiTiet = l.ChiTiet,
                        ThoiGian = l.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss")
                    })
                    .Take(200) // Chỉ lấy 200 dòng gần nhất cho nhanh app
                    .ToList();

                dataGridView.DataSource = query;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử: " + ex.Message);
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
                int maNVChon = (int)cboNhanVien.SelectedValue;

                using (var db = new Quan_Li_Lich_Lam_DbContext())
                {
                    // 1. Khởi tạo Query cơ bản với lọc Ngày
                    var query = db.Lich_Su_He_Thong
                                  .Include(l => l.Nhan_Vien)
                                  .Where(l => l.ThoiGian >= tuNgay && l.ThoiGian <= denNgay);

                    // 2. Nếu người dùng chọn đích danh 1 nhân viên thì lọc thêm mã
                    if (maNVChon != -1)
                    {
                        query = query.Where(l => l.MaNhanVien == maNVChon);
                    }

                    // 3. Thực thi truy vấn và hiển thị
                    var result = query.OrderByDescending(l => l.ThoiGian)
                                      .Select(l => new
                                      {
                                          l.MaNhanVien,
                                          l.HanhDong,
                                          l.ChiTiet,
                                          ThoiGian = l.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss")
                                      }).ToList();

                    dataGridView.DataSource = result;

                    if (result.Count == 0) MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "MaNhanVien" && e.Value != null)
            {
                // Thay vì hiện số ID, ta hiện tên loại
                var id = (int)e.Value;
                var item = context.Nhan_Vien.Find(id);
                if (item != null) e.Value = item.HoTen;
            }
        }

        private void btnLoc_Click_1(object sender, EventArgs e)
        {

            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
                int maNVChon = (int)cboNhanVien.SelectedValue;

                using (var db = new Quan_Li_Lich_Lam_DbContext())
                {
                    var query = db.Lich_Su_He_Thong
                                .Include(l => l.Nhan_Vien)
                                .Where(l => l.ThoiGian >= tuNgay && l.ThoiGian <= denNgay);

                    if (maNVChon != -1)
                    {
                        query = query.Where(l => l.MaNhanVien == maNVChon);
                    }

                    var result = query.OrderByDescending(l => l.ThoiGian)
                                    .Select(l => new
                                    {
                                        l.MaNhanVien,
                                        l.HanhDong,
                                        l.ChiTiet,
                                        ThoiGian = l.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss")
                                    }).ToList();

                    dataGridView.DataSource = result;

                    if (result.Count == 0) MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            frmLichSuHeThong_Load(sender, e);
        }
    }
}
