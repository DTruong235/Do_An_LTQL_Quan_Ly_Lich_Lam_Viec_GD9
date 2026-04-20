using Quan_Ly_Lich_Lam_Viec.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmDashBoard : frmBase
    {

        public frmDashBoard()
        {
            InitializeComponent();
        }

        Quan_Li_Lich_Lam_DbContext db = new Quan_Li_Lich_Lam_DbContext();

        private void LoadHeader()
        {
            if (Program.CurrentUser != null)
            {
                lblXinChaoHeader.Text = $"Xin chào, {Program.CurrentUser.Nhan_Vien.HoTen}!";
            }
            lblNgayThangHeader.Text = $"{DateTime.Now.ToString("dddd, dd/MM/yyyy")}";
        }


        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);
            LoadDashboard();
        }

        void LoadDashboard()
        {
            if (Program.CurrentUser.MaQuyen == 1)
            {
                lblTongDon.Text = db.DonNghiPheps.Count().ToString();
                lblTongChoDuyet.Text = db.DonNghiPheps.Count(x => x.TrangThai == 0).ToString();
                lblTongDaDuyet.Text = db.DonNghiPheps.Count(x => x.TrangThai == 1).ToString();
                lblTongTuChoi.Text = db.DonNghiPheps.Count(x => x.TrangThai == 2).ToString();
            }
            else
            {
                int maNhanVien = Program.CurrentUser.MaNhanVien;
                lblTongDon.Text = db.DonNghiPheps.Count(x => x.MaNhanVien == maNhanVien).ToString();
                lblTongChoDuyet.Text = db.DonNghiPheps.Count(x => x.MaNhanVien == maNhanVien && x.TrangThai == 0).ToString();
                lblTongDaDuyet.Text = db.DonNghiPheps.Count(x => x.MaNhanVien == maNhanVien && x.TrangThai == 1).ToString();
                lblTongTuChoi.Text = db.DonNghiPheps.Count(x => x.MaNhanVien == maNhanVien && x.TrangThai == 2).ToString();
            }

            if (Program.CurrentUser.MaQuyen == 1)
            {
                LoadChartTienDoAll();
                LoadChartPhanTram();
                chartTienDoUser.Visible = false;
            }
            else
            {
                LoadChartTienDoUser();
                chartTienDoAll.Visible = false;
                dataGridView.Columns["HoTen"].Visible = false;
            }
            LoadHeader();
            LoadGridCongViec();
        }

        void LoadChartTienDoAll()
        {
            chartTienDoAll.Series.Clear();
            SetChartTitle(chartTienDoAll, "Tiến độ toàn hệ thống");

            var series = chartTienDoAll.Series.Add("Tiến độ");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            int daXong = db.Chi_Tiet_Cong_Viecs.Count(x => x.TrangThai == true);
            int chuaXong = db.Chi_Tiet_Cong_Viecs.Count(x => x.TrangThai == false);

            series.Points.AddXY("Hoàn thành", daXong);
            series.Points.AddXY("Chưa xong", chuaXong);


            series.Points[0].Color = Color.Green;
            series.Points[1].Color = Color.Red;
        }

        void LoadChartTienDoUser()
        {
            chartTienDoUser.Series.Clear();
            SetChartTitle(chartTienDoUser, "Tiến độ cá nhân");

            var series = chartTienDoUser.Series.Add("Cá nhân");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            int maNV = Program.CurrentUser.MaNhanVien;

            var data = db.Chi_Tiet_Cong_Viecs
                .Where(x => x.Chi_Tiet_Phan_Cong.MaNhanVien == maNV)
                .ToList();

            int daXong = data.Count(x => x.TrangThai == true);
            int chuaXong = data.Count(x => x.TrangThai == false);

            series.Points.AddXY("Hoàn thành", daXong);
            series.Points.AddXY("Chưa xong", chuaXong);


            series.Points[0].Color = Color.Green;
            series.Points[1].Color = Color.Red;
        }


        void LoadChartPhanTram()
        {
            chartPhanTram.Series.Clear();
            SetChartTitle(chartPhanTram, "Phân tích tiến độ (%)");

            var series = chartPhanTram.Series.Add("Tiến độ %");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var data = db.Tien_Do_Cong_Viec.ToList();

            int thap = data.Count(x => x.PhanTramHoanThanh < 30);
            int trung = data.Count(x => x.PhanTramHoanThanh >= 30 && x.PhanTramHoanThanh < 80);
            int cao = data.Count(x => x.PhanTramHoanThanh >= 80);

            series.Points.AddXY("Thấp", thap);
            series.Points.AddXY("Trung bình", trung);
            series.Points.AddXY("Cao", cao);
        }

        void SetChartTitle(Chart chart, string text)
        {
            chart.Titles.Clear();

            var title = chart.Titles.Add(text);
            title.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            title.ForeColor = PrimaryColor;
            title.Alignment = ContentAlignment.MiddleCenter;
        }

        void LoadGridCongViec()
        {
            if (Program.CurrentUser.MaQuyen == 1)
            {
                dataGridView.DataSource = db.Chi_Tiet_Cong_Viecs
                    .Select(x => new
                    {
                        x.TenDauViec,
                        TrangThai = x.TrangThai ? "Hoàn thành" : "Chưa xong",
                        HoTen = x.Chi_Tiet_Phan_Cong.Nhan_Vien.HoTen
                    })
                    .ToList();
            }
            else
            {
                int maNV = Program.CurrentUser.MaNhanVien;

                dataGridView.DataSource = db.Chi_Tiet_Cong_Viecs
                    .Where(x => x.Chi_Tiet_Phan_Cong.MaNhanVien == maNV)
                    .Select(x => new
                    {

                        x.TenDauViec,
                        TrangThai = x.TrangThai ? "Hoàn thành" : "Chưa xong"
                    })
                    .ToList();
            }
        }
    }
}
