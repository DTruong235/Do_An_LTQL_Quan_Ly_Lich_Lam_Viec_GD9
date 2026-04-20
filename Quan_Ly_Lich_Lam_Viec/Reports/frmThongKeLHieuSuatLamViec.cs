using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Forms;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeLHieuSuatLamViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachHieuSuatLamViecDataTable dtHieuSuat = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachHieuSuatLamViecDataTable();

        public frmThongKeLHieuSuatLamViec()
        {
            InitializeComponent();
        }

        private void frmThongKeLHieuSuatLamViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            cboNhanVien.DataSource = context.Nhan_Vien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";

            var thongKe = context.Nhan_Vien.Select(nv => new
            {
                nv.HoTen,
                // Đếm tổng tất cả đầu việc từ các phân công của nhân viên này
                TongViec = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(),
                // Đếm số việc đã tích chọn TrangThai = true
                ViecXong = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(t => t.TrangThai == true)
            }).ToList();

            dtHieuSuat.Clear();

            foreach (var item in thongKe)
            {
                double phanTram = item.TongViec > 0 ? (double)item.ViecXong / item.TongViec * 100 : 0;

                dtHieuSuat.AddDanhSachHieuSuatLamViecRow(
                    item.HoTen,
                    item.TongViec,
                    item.ViecXong,
                    Math.Round(phanTram, 2)
                    );
            }

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachHieuSuatLamViec", (DataTable)dtHieuSuat));
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeHieuSuatLamViec.rdlc");
            reportViewer.LocalReport.ReportPath = rptPath;

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả nhân viên)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var query = context.Nhan_Vien
                                .Include(nv => nv.Chi_Tiet_Phan_Cong)
                                .ThenInclude(pc => pc.Chi_Tiet_Cong_Viec)
                                .Where(nv => nv.MaNhanVien == (int)cboNhanVien.SelectedValue)
                                .Select(nv => new
                                {
                                    nv.MaNhanVien,
                                    nv.HoTen,
                                    TongViec = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(),
                                    ViecXong = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(t => t.TrangThai == true)
                                })
                                .AsQueryable();

            string tenNV = "";

            if (cboNhanVien.SelectedIndex != -1 && cboNhanVien.SelectedValue != null)
            {
                int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                query = query.Where(c => c.MaNhanVien == maNV);
                tenNV = "Nhân viên: " + cboNhanVien.Text;
            }
            dtHieuSuat.Clear();

            var ketQua = query.ToString();

            foreach (var item in query)
            {
                double phanTram = item.TongViec > 0 ? (double)item.ViecXong / item.TongViec * 100 : 0;
                dtHieuSuat.AddDanhSachHieuSuatLamViecRow(
                    item.HoTen,
                    item.TongViec,
                    item.ViecXong,
                    Math.Round(phanTram, 2)
                    );
            }

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachHieuSuatLamViec", (DataTable)dtHieuSuat));
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeHieuSuatLamViec.rdlc");
            rptPath = Path.GetFullPath(rptPath);
            reportViewer.LocalReport.ReportPath = rptPath;

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", tenNV);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmThongKeLHieuSuatLamViec_Load(sender, e);
        }
    }
}
