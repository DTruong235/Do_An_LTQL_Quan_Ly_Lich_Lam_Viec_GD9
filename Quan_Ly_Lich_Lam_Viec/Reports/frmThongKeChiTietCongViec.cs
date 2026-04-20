using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Forms;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeChiTietCongViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachChiTietCongViecDataTable dtChiTiet = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachChiTietCongViecDataTable();
        public frmThongKeChiTietCongViec()
        {
            InitializeComponent();
        }

        private void frmThongKeChiTietCongViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            cboNhanVien.DataSource = context.Nhan_Vien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";

            cboTenLich.DataSource = context.Lich_Lam_Viec.ToList();
            cboTenLich.DisplayMember = "TieuDe";
            cboTenLich.ValueMember = "MaLich";

            try
            {
                var query = context.Chi_Tiet_Cong_Viecs.Select(c => new
                {
                    HoTen = c.Chi_Tiet_Phan_Cong.Nhan_Vien.HoTen,
                    TieuDeLich = c.Chi_Tiet_Phan_Cong.Lich_Lam_Viec.TieuDe,
                    c.TenDauViec,
                    c.TrangThai
                }).ToList();

                dtChiTiet.Clear();

                foreach (var item in query)
                {
                    dtChiTiet.AddDanhSachChiTietCongViecRow(
                        item.HoTen,
                        item.TieuDeLich,
                        item.TenDauViec,
                        item.TrangThai ? "Đã hoàn thành" : "Chưa hoàn thành" // Chuyển bool sang chữ
                    );
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachChiTietCongViec", (DataTable)dtChiTiet));
                string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeChiTietCongViec.rdlc");
                reportViewer.LocalReport.ReportPath = rptPath;

                ReportParameter rp = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả chi tiết công việc)");
                reportViewer.LocalReport.SetParameters(rp);

                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var query = context.Chi_Tiet_Cong_Viecs
                               .Include(c => c.Chi_Tiet_Phan_Cong)
                               .ThenInclude(pc => pc.Nhan_Vien)
                               .Include(c => c.Chi_Tiet_Phan_Cong)
                               .ThenInclude(pc => pc.Lich_Lam_Viec)
                               .AsQueryable();

            string moTaNhanVien = "";
            string moTaLich = "";

            if (cboNhanVien.SelectedIndex != -1)
            {
                int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                query = query.Where(c => c.Chi_Tiet_Phan_Cong.Nhan_Vien.MaNhanVien == maNV);
                moTaNhanVien = "Nhân viên: " + cboNhanVien.Text;

            }

            if (cboTenLich.SelectedIndex != -1)
            {
                int maLich = Convert.ToInt32(cboTenLich.SelectedValue);
                query = query.Where(c => c.Chi_Tiet_Phan_Cong.Lich_Lam_Viec.MaLich == maLich);
                moTaLich = "Lịch: " + cboTenLich.Text;
            }

            var ketQua = query.ToList();

            dtChiTiet.Clear();

            foreach (var item in ketQua)
            {
                dtChiTiet.AddDanhSachChiTietCongViecRow(
                    item.Chi_Tiet_Phan_Cong.Nhan_Vien.HoTen,
                    item.Chi_Tiet_Phan_Cong.Lich_Lam_Viec.TieuDe,
                    item.TenDauViec,
                    item.TrangThai ? "Đã hoàn thành" : "Chưa hoàn thành"
                );
            }

            string moTa = $" {moTaNhanVien} - {moTaLich}";

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachChiTietCongViec", (DataTable)dtChiTiet));
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeChiTietCongViec.rdlc");
            rptPath = Path.GetFullPath(rptPath);
            reportViewer.LocalReport.ReportPath = rptPath;

            ReportParameter rp = new ReportParameter("MoTaKetQuaHienThi", moTa);
            reportViewer.LocalReport.SetParameters(rp);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmThongKeChiTietCongViec_Load(sender, e);
        }
    }
}
