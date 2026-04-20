using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Forms;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeTienDoCongViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachTienDoCongViecDataTable dtTienDo = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachTienDoCongViecDataTable();

        public frmThongKeTienDoCongViec()
        {
            InitializeComponent();
        }

        private void frmThongKeTienDoCongViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            cboTenLich.DataSource = context.Lich_Lam_Viec.ToList();
            cboTenLich.DisplayMember = "TieuDe";
            cboTenLich.ValueMember = "MaLich";

            try
            {
                var data = context.Tien_Do_Cong_Viec
                                    .Include(t => t.Lich_Lam_Viec)
                                    .Select(t => new
                                    {
                                        TenLich = t.Lich_Lam_Viec.TieuDe,
                                        PhanTram = t.PhanTramHoanThanh,
                                        GhiChu = t.GhiChu,
                                        Ngay = t.NgayCapNhat.ToString("dd/MM/yyyy")
                                    }).ToList();

                var dt = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachTienDoCongViecDataTable();

                foreach (var item in data)
                {
                    dt.AddDanhSachTienDoCongViecRow(item.TenLich, item.PhanTram, item.GhiChu, item.Ngay);
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachTienDoCongViec", (DataTable)dt));

                string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeTienDoCongViec.rdlc");
                rptPath = Path.GetFullPath(rptPath);
                reportViewer.LocalReport.ReportPath = rptPath;

                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả tiến độ công việc)");
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
            var query = context.Tien_Do_Cong_Viec
                        .Include(t => t.Lich_Lam_Viec)
                        .Include(t => t.Lich_Lam_Viec.Chi_Tiet_Phan_Cong)
                        .Select(t => new
                        {
                            TenLich = t.Lich_Lam_Viec.TieuDe,
                            PhanTram = t.PhanTramHoanThanh,
                            GhiChu = t.GhiChu,
                            Ngay = t.NgayCapNhat.ToString("dd/MM/yyyy"),
                            MaLich = t.MaLich
                        });

            string moTaLich = "";

            if (cboTenLich.SelectedIndex != -1 && cboTenLich.SelectedValue != null)
            {
                int maLich = Convert.ToInt32(cboTenLich.SelectedValue);
                query = query.Where(c => c.MaLich == maLich);
                moTaLich = "Lịch: " + cboTenLich.Text;
            }

            var ketQua = query.ToList();

            dtTienDo.Clear();

            foreach (var item in ketQua)
            {
                dtTienDo.AddDanhSachTienDoCongViecRow(
                    item.TenLich,
                    item.PhanTram,
                    item.GhiChu,
                    item.Ngay
                );

            }

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachTienDoCongViec", (DataTable)dtTienDo));
            //string rptPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeTienDoCongViec.rdlc");
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeTienDoCongViec.rdlc");
            rptPath = Path.GetFullPath(rptPath);
            reportViewer.LocalReport.ReportPath = rptPath;

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", moTaLich);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmThongKeTienDoCongViec_Load(sender, e);
        }
    }
}
