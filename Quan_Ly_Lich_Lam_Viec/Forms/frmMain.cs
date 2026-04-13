
using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.GiaoDien;
using Quan_Ly_Lich_Lam_Viec.Reports;
using System.Diagnostics;
using BC = BCrypt.Net.BCrypt;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmMain : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        string hoVaTenNhanVien = "";
        string tenDangNhap = "";

        frmDangNhap dangNhap = null;
        frmDiaDiem diaDiem = null;
        frmDoiMatKhau doiMatKhau = null;
        frmLichLamViec lichLamViec = null;
        frmLoaiCongViec loaiCongViec = null;
        frmNhanVien nhanVien = null;
        frmPhanCong phanCong = null;
        frmTaiKhoan taiKhoan = null;
        frmTienDoCongViec tienDoCongViec = null;
        frmThongKeTienDoCongViec thongKeTienDoCongViec = null;
        frmThongKeLichLamViec thongKeLichLamViec = null;
        frmThongKeChiTietCongViec thongKeChiTietCongViec = null;
        frmThongKeLHieuSuatLamViec thongKeHieuSuatLamViec = null;
        frmLichSuHeThong lichSuHeThong = null;
        frmDashBoard dashboard = null;
        frmCaiDat caiDat = null;

        public frmMain()
        {
            InitializeComponent();

        }

        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuNhanVien.Enabled = false;

            mnuLichLamViec.Enabled = false;
            mnuPhanCong.Enabled = false;
            mnuTienDoCongViec.Enabled = false;
            mnuLoaiCongViec.Enabled = false;
            mnuDiaDiem.Enabled = false;
            mnuTaiKhoan.Enabled = false;

            mnuThongKeChiTietCongViec.Enabled = false;
            mnuThongKeHieuSuatLamViec.Enabled = false;
            mnuThongKeLichLamViec.Enabled = false;
            mnuThongKeTienDoCongViec.Enabled = false;
            mnuLichSuHeThong.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void DangNhap()
        {
        Lamlai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {

                string tenDN = dangNhap.TenDangNhap;
                string matKhau = dangNhap.MatKhau;

                if (tenDN == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Lamlai;
                }
                else if (matKhau == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Lamlai;
                }
                else
                {
                    var taiKhoan = context.Tai_Khoan
                        .Include(tk => tk.Nhan_Vien)
                        .FirstOrDefault(tk => tk.Username == tenDN);

                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Lamlai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, taiKhoan.Password))
                        {
                            Program.CurrentUser = taiKhoan;
                            tenDangNhap = taiKhoan.Username;
                            hoVaTenNhanVien = taiKhoan.Nhan_Vien.HoTen;
                            if (taiKhoan.MaQuyen == 1)
                                QuyenQuanLy();
                            else if (taiKhoan.MaQuyen == 0)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                            DataHelper.WriteLog("Đăng nhập", $"Người dùng {Program.CurrentUser.Username} đã vào hệ thống.");
                            HienThiDashboard();

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Lamlai;
                        }
                    }
                }
            }
        }

        public void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuNhanVien.Enabled = true;
            mnuTaiKhoan.Enabled = true;
            mnuLichLamViec.Enabled = true;
            mnuPhanCong.Enabled = true;
            mnuTienDoCongViec.Enabled = true;
            mnuLoaiCongViec.Enabled = true;
            mnuDiaDiem.Enabled = true;

            mnuThongKeLichLamViec.Enabled = true;
            mnuThongKeChiTietCongViec.Enabled = true;
            mnuThongKeTienDoCongViec.Enabled = true;
            mnuThongKeHieuSuatLamViec.Enabled = true;

            mnuLichSuHeThong.Enabled = true;

            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;

            mnuNhanVien.Enabled = false;
            mnuTaiKhoan.Enabled = false;

            mnuLichLamViec.Enabled = true;
            mnuPhanCong.Enabled = true;
            mnuTienDoCongViec.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. Load cấu hình từ file JSON
            ThemeManager.LoadConfig();

            // 2. Setup ảnh nền cho không gian làm việc của Form Main (MDI Client)
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient) // Tìm đúng cái tấm nền xám của Form Main
                {
                    ctl.BackColor = ThemeManager.Config.IsDarkMode ? Color.FromArgb(20, 20, 20) : Color.DarkGray;

                    if (!string.IsNullOrEmpty(ThemeManager.Config.BackgroundImagePath) && File.Exists(ThemeManager.Config.BackgroundImagePath))
                    {
                        ctl.BackgroundImage = Image.FromFile(ThemeManager.Config.BackgroundImagePath);
                        ctl.BackgroundImageLayout = ImageLayout.Stretch; // Hoặc Zoom tùy bạn
                    }
                    break;
                }
            }

            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DataHelper.WriteLog("Đăng xuất", $"Người dùng {Program.CurrentUser.Username} đã đăng xuất khỏi hệ thống.");
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void mnuDiaDiem_Click(object sender, EventArgs e)
        {
            if (diaDiem == null || diaDiem.IsDisposed)
            {
                diaDiem = new frmDiaDiem();
                diaDiem.MdiParent = this;
                diaDiem.Show();
            }
            else
                diaDiem.Activate();
        }

        private void mnuLichLamViec_Click(object sender, EventArgs e)
        {
            if (lichLamViec == null || lichLamViec.IsDisposed)
            {
                lichLamViec = new frmLichLamViec();
                lichLamViec.MdiParent = this;
                lichLamViec.Show();
            }
            else lichLamViec.Activate();
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            if (phanCong == null || phanCong.IsDisposed)
            {
                phanCong = new frmPhanCong();
                phanCong.MdiParent = this;
                phanCong.Show();
            }
            else phanCong.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else nhanVien.Activate();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoan == null || taiKhoan.IsDisposed)
            {
                taiKhoan = new frmTaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
            else taiKhoan.Activate();
        }

        private void lblLienKet_Click_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuTienDoCongViec_Click(object sender, EventArgs e)
        {
            if (tienDoCongViec == null || tienDoCongViec.IsDisposed)
            {
                tienDoCongViec = new frmTienDoCongViec();
                tienDoCongViec.MdiParent = this;
                tienDoCongViec.Show();
            }
            else tienDoCongViec.Activate();
        }

        private void mnuThongKeTienDoCongViec_Click(object sender, EventArgs e)
        {
            if (thongKeTienDoCongViec == null || thongKeTienDoCongViec.IsDisposed)
            {
                thongKeTienDoCongViec = new frmThongKeTienDoCongViec();
                thongKeTienDoCongViec.MdiParent = this;
                thongKeTienDoCongViec.Show();
            }
            else thongKeTienDoCongViec.Activate();
        }

        private void mnuThongKeLichLamViec_Click(object sender, EventArgs e)
        {
            if (thongKeLichLamViec == null || thongKeLichLamViec.IsDisposed)
            {
                thongKeLichLamViec = new frmThongKeLichLamViec();
                thongKeLichLamViec.MdiParent = this;
                thongKeLichLamViec.Show();
            }
            else thongKeLichLamViec.Activate();
        }

        private void mnuThongKeChiTietCongViec_Click(object sender, EventArgs e)
        {
            if (thongKeChiTietCongViec == null || thongKeChiTietCongViec.IsDisposed)
            {
                thongKeChiTietCongViec = new frmThongKeChiTietCongViec();
                thongKeChiTietCongViec.MdiParent = this;
                thongKeChiTietCongViec.Show();
            }
            else thongKeChiTietCongViec.Activate();
        }

        private void mnuThongKeHieuSuatLamViec_Click(object sender, EventArgs e)
        {
            if (thongKeHieuSuatLamViec == null || thongKeHieuSuatLamViec.IsDisposed)
            {
                thongKeHieuSuatLamViec = new frmThongKeLHieuSuatLamViec();
                thongKeHieuSuatLamViec.MdiParent = this;
                thongKeHieuSuatLamViec.Show();
            }
            else thongKeHieuSuatLamViec.Activate();
        }

        private void mnuLichSuHeThong_Click(object sender, EventArgs e)
        {
            if (lichSuHeThong == null || lichSuHeThong.IsDisposed)
            {
                lichSuHeThong = new frmLichSuHeThong();
                lichSuHeThong.MdiParent = this;
                lichSuHeThong.Show();
            }
            else lichSuHeThong.Activate();
        }

        private void mnuLoaiCongViec_Click(object sender, EventArgs e)
        {
            if (loaiCongViec == null || loaiCongViec.IsDisposed)
            {
                loaiCongViec = new frmLoaiCongViec();
                loaiCongViec.MdiParent = this;
                loaiCongViec.Show();
            }
            else loaiCongViec.Activate();
        }

        private void HienThiDashboard()
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new frmDashBoard();
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            HienThiDashboard();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCauHinh_Click(object sender, EventArgs e)
        {
            if (caiDat == null || caiDat.IsDisposed)
            {
                caiDat = new frmCaiDat();
                caiDat.Show();
            }
            else caiDat.Activate();
        }
    }
}
