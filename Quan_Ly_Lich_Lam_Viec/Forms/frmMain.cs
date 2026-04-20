using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.GiaoDien;
using Quan_Ly_Lich_Lam_Viec.Helper;
using Quan_Ly_Lich_Lam_Viec.Reports;
using System.Diagnostics;
using BC = BCrypt.Net.BCrypt;
using Path = System.IO.Path;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmMain : frmBase
    {

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        string hoVaTenNhanVien = "";
        string tenDangNhap = "";

        frmDangNhap dangNhap = null;
        frmDoiMatKhau doiMatKhau = null;


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

            pnlSidebar.Visible = false;

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
                            pnlSidebar.Visible = true;
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

            btnNhanVien.Enabled = false;
            btnTaiKhoan.Enabled = false;

            btnThongKeChiTietCongViec.Enabled = false;
            btnThongKeHieuSuatLamViec.Enabled = false;
            btnThongKeLichLamViec.Enabled = false;
            btnThongKeTienDoCongViec.Enabled = false;
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);
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
            foreach (Form form in panelMain.Controls)
            {
                form.Close();
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
            OpenChildForm(new frmDiaDiem());
        }

        private void mnuLichLamViec_Click(object sender, EventArgs e)
        {
            btnLichLamViec_Click(sender, e);
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhanCong());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            btnNhanVien_Click(sender, e);
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            btnTaiKhoan_Click(sender, e);
        }

        private void lblLienKet_Click_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://github.com/DTruong235/Do_An_LTQL_Quan_Ly_Lich_Lam_Viec_GD9";
            Process.Start(info);
        }

        private void mnuTienDoCongViec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTienDoCongViec());
        }

        private void mnuThongKeTienDoCongViec_Click(object sender, EventArgs e)
        {
            btnThongKeTienDoCongViec_Click(sender, e);
        }

        private void mnuThongKeLichLamViec_Click(object sender, EventArgs e)
        {
            btnThongKeLichLamViec_Click(sender, e);
        }

        private void mnuThongKeChiTietCongViec_Click(object sender, EventArgs e)
        {
            btnThongKeChiTietCongViec_Click(sender, e);
        }

        private void mnuThongKeHieuSuatLamViec_Click(object sender, EventArgs e)
        {
            btnThongKeHieuSuatLamViec_Click(sender, e);
        }

        private void mnuLichSuHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichSuHeThong());
        }

        private void mnuLoaiCongViec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiCongViec());
        }

        private void HienThiDashboard()
        {
            ActivateButton(btnDashboard);
            OpenChildForm(new frmDashBoard());
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
            btnCaiDat_Click(sender, e);
        }

        private void mnuHDSD_Click(object sender, EventArgs e)
        {
            MoFileHuongDan();
        }

        private void MoFileHuongDan()
        {
            try
            {
                // Trỏ đúng vào thư mục Help bạn đã tạo trong Project
                string helpPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Help", "HDSD.html");

                if (File.Exists(helpPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = helpPath,
                        UseShellExecute = true // Yêu cầu Windows dùng trình duyệt mặc định
                    });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hướng dẫn tại: " + helpPath, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở hướng dẫn: " + ex.Message);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            panelMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.Show();
        }


        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            ActivateButton(btnLichLamViec);
            OpenChildForm(new frmLichLamViec());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HienThiDashboard();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(btnNhanVien);
            OpenChildForm(new frmNhanVien());

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCaiDat);
            OpenChildForm(new frmCaiDat());
        }

        private void ActivateButton(Button btn)
        {
            if (currentButton != null)
                currentButton.BackColor = PrimaryColor;

            currentButton = btn;

            btn.BackColor = ControlPaint.Dark(PrimaryColor, 0.2f);
        }



        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(btnTaiKhoan);
            OpenChildForm(new frmTaiKhoan());
        }

        private void mnuNghiPhep_Click(object sender, EventArgs e)
        {
            btnDonNghiPhep_Click(sender, e);
        }

        private void btnDonNghiPhep_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDonNghiPhep);
            OpenChildForm(new frmDonNghiPhep());
        }

        private void btnThongKeLichLamViec_Click(object sender, EventArgs e)
        {
            ActivateButton(btnThongKeLichLamViec);
            OpenChildForm(new frmThongKeLichLamViec());

        }

        private void btnThongKeChiTietCongViec_Click(object sender, EventArgs e)
        {
            ActivateButton(btnThongKeChiTietCongViec);
            OpenChildForm(new frmThongKeChiTietCongViec());
        }

        private void btnThongKeHieuSuatLamViec_Click(object sender, EventArgs e)
        {
            ActivateButton(btnThongKeHieuSuatLamViec);
            OpenChildForm(new frmThongKeLHieuSuatLamViec());
        }

        private void btnThongKeTienDoCongViec_Click(object sender, EventArgs e)
        {
            ActivateButton(btnThongKeTienDoCongViec);
            OpenChildForm(new frmThongKeTienDoCongViec());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }
    }
}
