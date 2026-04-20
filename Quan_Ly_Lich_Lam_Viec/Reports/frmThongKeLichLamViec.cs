using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Forms;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeLichLamViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachLichLamViecDataTable dtLich = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachLichLamViecDataTable();
        public frmThongKeLichLamViec()
        {
            InitializeComponent();
        }

        private void frmThongKeLichLamViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            try
            {
                var query = context.Lich_Lam_Viec.Select(r => new
                {
                    r.TieuDe,
                    r.ThoiGianBatDau,
                    r.ThoiGianKetThuc,
                    TenLoai = r.Loai_Cong_Viec.TenLoai,
                    TenDiaDiem = r.Dia_Diem.TenDiaDiem,
                    r.SoLuongDuKien
                }).ToList();

                dtLich.Clear();

                foreach (var item in query)
                {
                    dtLich.AddDanhSachLichLamViecRow(
                        item.TieuDe,
                        item.ThoiGianBatDau,
                        item.ThoiGianKetThuc,
                        item.TenDiaDiem,
                        item.TenLoai,
                        item.SoLuongDuKien
                    );
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachLichLamViec", (DataTable)dtLich));
                string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeLichLamViec.rdlc");

                reportViewer.LocalReport.ReportPath = rptPath;

                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả lịch làm việc)");
                reportViewer.LocalReport.SetParameters(reportParameter);
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
            DateTime tuNgay = dtpBatDau.Value;
            DateTime denNgay = dtpKetThuc.Value;

            var query = context.Lich_Lam_Viec
                               .Where(r => r.ThoiGianBatDau >= tuNgay && r.ThoiGianBatDau <= denNgay)
                               .Select(r => new
                               {
                                   r.TieuDe,
                                   r.ThoiGianBatDau,
                                   r.ThoiGianKetThuc,
                                   TenLoai = r.Loai_Cong_Viec.TenLoai,
                                   TenDiaDiem = r.Dia_Diem.TenDiaDiem,
                                   r.SoLuongDuKien
                               }).ToList();

            dtLich.Clear();
            foreach (var item in query)
            {
                dtLich.AddDanhSachLichLamViecRow(
                    item.TieuDe,
                    item.ThoiGianBatDau,
                    item.ThoiGianKetThuc,
                    item.TenDiaDiem,
                    item.TenLoai,
                    item.SoLuongDuKien
                );
            }

            string moTa = $"{dtpBatDau.Text} - {dtpKetThuc.Text}";

            reportViewer.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DanhSachLichLamViec", (DataTable)dtLich);
            reportViewer.LocalReport.DataSources.Add(rds);

            ReportParameter rp = new ReportParameter("MoTaKetQuaHienThi", moTa);

            reportViewer.LocalReport.SetParameters(rp);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmThongKeLichLamViec_Load(sender, e);
        }

        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
