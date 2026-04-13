using Microsoft.EntityFrameworkCore;
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

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);
            TrangTriGiaoDien();

            LoadHeader();
            LoadSoLieuDashboard();
            VeBieuDoThongKe();
        }

        private void LoadHeader()
        {
            if (Program.CurrentUser != null)
            {
                lblXinChao.Text = $"Xin chào, {Program.CurrentUser.Nhan_Vien.HoTen}!";
            }
            lblNgayThang.Text = $"{DateTime.Now.ToString("dddd, dd/MM/yyyy")}";
        }

        private void LoadSoLieuDashboard()
        {
            using (var context = new Quan_Li_Lich_Lam_DbContext())
            {
                DateTime now = DateTime.Now;
                DateTime homNay = now.Date;

                var queryLich = context.Lich_Lam_Viec
                                       .Include(l => l.Tien_Do_Cong_Viec)
                                       .AsQueryable();

                // Lọc theo quyền
                if (Program.CurrentUser.MaQuyen == 0)
                {
                    queryLich = queryLich.Where(l => l.Chi_Tiet_Phan_Cong.Any(pc => pc.MaNhanVien == Program.CurrentUser.MaNhanVien));
                }

                // Card 1: Tổng lịch hôm nay
                int soLichHomNay = queryLich.Count(l => l.ThoiGianBatDau.Date == homNay);
                lblSoCard1.Text = soLichHomNay.ToString();

                // Card 2: Sắp trễ hạn (Deadline trong 2 ngày tới & Chưa xong 100%)
                int soLichSapTre = queryLich.Count(l =>
                    l.ThoiGianKetThuc >= now &&
                    l.ThoiGianKetThuc <= now.AddDays(2) &&
                    (!l.Tien_Do_Cong_Viec.Any() || l.Tien_Do_Cong_Viec.OrderByDescending(t => t.NgayCapNhat).FirstOrDefault().PhanTramHoanThanh < 100));
                lblSoCard2.Text = soLichSapTre.ToString();

                // Card 3: Đã hoàn thành
                int soLichHoanThanh = queryLich.Count(l =>
                    l.Tien_Do_Cong_Viec.Any(t => t.PhanTramHoanThanh == 100));
                lblSoCard3.Text = soLichHoanThanh.ToString();


                var queryTienDo = context.Tien_Do_Cong_Viec
                                 .Include(t => t.Lich_Lam_Viec)
                                 .Include(t => t.Lich_Lam_Viec.Dia_Diem)
                                 .AsQueryable();

                if (Program.CurrentUser.MaQuyen == 0)
                {
                    // Nhân viên chỉ được xem nhật ký tiến độ của những lịch mà họ có tham gia
                    queryTienDo = queryTienDo.Where(t => t.Lich_Lam_Viec.Chi_Tiet_Phan_Cong.Any(pc => pc.MaNhanVien == Program.CurrentUser.MaNhanVien));
                }

                var nhatKyMoiNhat = queryTienDo
                                     .OrderByDescending(t => t.NgayCapNhat)
                                     .Take(10)
                                     .Select(t => new
                                     {
                                         TieuDe = t.Lich_Lam_Viec.TieuDe,
                                         ThoiGianBatDau = t.Lich_Lam_Viec.ThoiGianBatDau.ToString("dd/MM/yyyy HH:mm"),
                                         ThoiGianKetThuc = t.Lich_Lam_Viec.ThoiGianKetThuc.ToString("dd/MM/yyyy HH:mm"),
                                         MaDiaDiem = t.Lich_Lam_Viec.Dia_Diem != null ? t.Lich_Lam_Viec.Dia_Diem.TenDiaDiem : "Chưa xác định",
                                         PhanTramHoanThanh = t.PhanTramHoanThanh + "%"
                                     }).ToList();

                dataGridView.DataSource = nhatKyMoiNhat;
            }
        }

        private void VeBieuDoThongKe()
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();
            chartThongKe.Legends.Clear();

            chartThongKe.Titles.Add("TỔNG QUAN TIẾN ĐỘ");
            chartThongKe.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartThongKe.Titles[0].ForeColor = Color.DarkBlue;

            Series series = new Series("Tiến độ");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            series.IsXValueIndexed = true;

            series.Points.AddXY("Hôm nay", int.Parse(lblSoCard1.Text));
            series.Points[0].Color = Color.DodgerBlue;

            series.Points.AddXY("Sắp đến hạn", int.Parse(lblSoCard2.Text));
            series.Points[1].Color = Color.DarkOrange;

            series.Points.AddXY("Đã hoàn thành", int.Parse(lblSoCard3.Text));
            series.Points[2].Color = Color.MediumSeaGreen;

            chartThongKe.Series.Add(series);

            chartThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới dọc
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Lưới ngang màu nhạt

            chartThongKe.ChartAreas[0].AxisY.Interval = 1;
        }

        private void MoForm(Form frmMoi)
        {
            // Mở form mới trong Form Cha (MDI Parent) nếu có, ngược lại thì Show bình thường
            if (this.MdiParent != null)
            {
                frmMoi.MdiParent = this.MdiParent;
                frmMoi.Show();
            }
            else
            {
                frmMoi.ShowDialog();
            }
        }

        private void pnlCard1_Click(object sender, EventArgs e)
        {
            MoForm(new frmLichLamViec());
        }

        private void pnlCard2_Click(object sender, EventArgs e)
        {
            frmLichLamViec frm = new frmLichLamViec();
            frm.boLocSapTre = true;
            MoForm(frm);

        }

        private void pnlCard3_Click(object sender, EventArgs e)
        {
            MoForm(new frmTienDoCongViec());
        }

        private void chartThongKe_Click(object sender, EventArgs e)
        {
            MoForm(new frmTienDoCongViec());
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            MoForm(new frmLichLamViec());
        }

        private void TrangTriGiaoDien()
        {
            string tenFont = "Segoe UI";

            lblXinChao.Font = new Font(tenFont, 20, FontStyle.Bold);
            lblXinChao.ForeColor = Color.DarkBlue;

            lblNgayThang.Font = new Font(tenFont, 15, FontStyle.Bold | FontStyle.Italic);
            lblNgayThang.ForeColor = Color.DarkOrange;

            lblTieuDeCard1.Font = new Font(tenFont, 12, FontStyle.Bold);
            lblTieuDeCard1.ForeColor = Color.White;
            lblSoCard1.Font = new Font(tenFont, 18, FontStyle.Bold);
            lblSoCard1.ForeColor = Color.White;

            lblTieuDeCard2.Font = new Font(tenFont, 12, FontStyle.Bold);
            lblTieuDeCard2.ForeColor = Color.White;
            lblSoCard2.Font = new Font(tenFont, 18, FontStyle.Bold);
            lblSoCard2.ForeColor = Color.White;

            lblTieuDeCard3.Font = new Font(tenFont, 12, FontStyle.Bold);
            lblTieuDeCard3.ForeColor = Color.White;
            lblSoCard3.Font = new Font(tenFont, 18, FontStyle.Bold);
            lblSoCard3.ForeColor = Color.White;

            lblTieuDeGrid.Font = new Font(tenFont, 15, FontStyle.Bold);
            lblTieuDeGrid.ForeColor = Color.Blue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLichLamViec frm = new frmLichLamViec();
            frm.xuLyThem = true;
            MoForm(frm);
        }

        private void lblTieuDeGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
