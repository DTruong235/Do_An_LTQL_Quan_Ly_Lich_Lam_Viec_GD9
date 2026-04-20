using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmInDonNghiPhep : Form
    {
        public frmInDonNghiPhep(int maDon)
        {
            InitializeComponent();
            id = maDon;
        }
        Quan_Li_Lich_Lam_DbContext db = new Quan_Li_Lich_Lam_DbContext();
        int id;

        private void frmInDonNghiPhep_Load(object sender, EventArgs e)
        {
            var data = db.DonNghiPheps
            .Where(x => x.Id == id)
            .Select(x => new
            {
                TenNhanVien = x.Nhan_Vien.HoTen,
                LyDo = x.LyDo,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                PhongBan = x.Nhan_Vien.Phong_Ban.TenPhong,
                ChucVu = x.Nhan_Vien.Chuc_Vu.TenChucVu,
                DiaChi = x.Nhan_Vien.DiaChi
            })
            .ToList();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachDonNghiPhep", data));
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptDonNghiPhep.rdlc");
            rptPath = Path.GetFullPath(rptPath);
            reportViewer1.LocalReport.ReportPath = rptPath;

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();

        }
    }

}
