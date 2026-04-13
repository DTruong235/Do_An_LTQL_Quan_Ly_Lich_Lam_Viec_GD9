namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuTrangChu = new ToolStripMenuItem();
            mnuDiaDiem = new ToolStripMenuItem();
            mnuLichLamViec = new ToolStripMenuItem();
            mnuPhanCong = new ToolStripMenuItem();
            mnuTienDoCongViec = new ToolStripMenuItem();
            mnuLoaiCongViec = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuNhanVien = new ToolStripMenuItem();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeLichLamViec = new ToolStripMenuItem();
            mnuThongKeChiTietCongViec = new ToolStripMenuItem();
            mnuThongKeTienDoCongViec = new ToolStripMenuItem();
            mnuThongKeHieuSuatLamViec = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuLichSuHeThong = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuCauHinh = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet_Click = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(190, 26);
            mnuDangNhap.Text = "Đăng nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(190, 26);
            mnuDangXuat.Text = "Đăng xuất...";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(190, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.F14;
            mnuThoat.Size = new Size(190, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.TextImageRelation = TextImageRelation.TextAboveImage;
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuTrangChu, mnuDiaDiem, mnuLichLamViec, mnuPhanCong, mnuTienDoCongViec, mnuLoaiCongViec, toolStripSeparator2, mnuNhanVien, mnuTaiKhoan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(73, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuTrangChu
            // 
            mnuTrangChu.Name = "mnuTrangChu";
            mnuTrangChu.Size = new Size(224, 26);
            mnuTrangChu.Text = "Màn hình chính...";
            mnuTrangChu.Click += mnuTrangChu_Click;
            // 
            // mnuDiaDiem
            // 
            mnuDiaDiem.Name = "mnuDiaDiem";
            mnuDiaDiem.Size = new Size(224, 26);
            mnuDiaDiem.Text = "Địa điểm";
            mnuDiaDiem.Click += mnuDiaDiem_Click;
            // 
            // mnuLichLamViec
            // 
            mnuLichLamViec.Name = "mnuLichLamViec";
            mnuLichLamViec.Size = new Size(224, 26);
            mnuLichLamViec.Text = "Lịch làm việc";
            mnuLichLamViec.Click += mnuLichLamViec_Click;
            // 
            // mnuPhanCong
            // 
            mnuPhanCong.Name = "mnuPhanCong";
            mnuPhanCong.Size = new Size(224, 26);
            mnuPhanCong.Text = "Phân công";
            mnuPhanCong.Click += mnuPhanCong_Click;
            // 
            // mnuTienDoCongViec
            // 
            mnuTienDoCongViec.Name = "mnuTienDoCongViec";
            mnuTienDoCongViec.Size = new Size(224, 26);
            mnuTienDoCongViec.Text = "Tiến độ công việc";
            mnuTienDoCongViec.Click += mnuTienDoCongViec_Click;
            // 
            // mnuLoaiCongViec
            // 
            mnuLoaiCongViec.Name = "mnuLoaiCongViec";
            mnuLoaiCongViec.Size = new Size(224, 26);
            mnuLoaiCongViec.Text = "Loại công việc";
            mnuLoaiCongViec.Click += mnuLoaiCongViec_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(224, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(224, 26);
            mnuTaiKhoan.Text = "Tài khoản";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeLichLamViec, mnuThongKeChiTietCongViec, mnuThongKeTienDoCongViec, mnuThongKeHieuSuatLamViec, toolStripSeparator3, mnuLichSuHeThong });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(152, 24);
            mnuBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeLichLamViec
            // 
            mnuThongKeLichLamViec.Name = "mnuThongKeLichLamViec";
            mnuThongKeLichLamViec.Size = new Size(283, 26);
            mnuThongKeLichLamViec.Text = "Thống kê Lịch làm việc";
            mnuThongKeLichLamViec.Click += mnuThongKeLichLamViec_Click;
            // 
            // mnuThongKeChiTietCongViec
            // 
            mnuThongKeChiTietCongViec.Name = "mnuThongKeChiTietCongViec";
            mnuThongKeChiTietCongViec.Size = new Size(283, 26);
            mnuThongKeChiTietCongViec.Text = "Thống kê Chi tiết công việc";
            mnuThongKeChiTietCongViec.Click += mnuThongKeChiTietCongViec_Click;
            // 
            // mnuThongKeTienDoCongViec
            // 
            mnuThongKeTienDoCongViec.Name = "mnuThongKeTienDoCongViec";
            mnuThongKeTienDoCongViec.Size = new Size(283, 26);
            mnuThongKeTienDoCongViec.Text = "Thống kê Tiến độ công việc";
            mnuThongKeTienDoCongViec.Click += mnuThongKeTienDoCongViec_Click;
            // 
            // mnuThongKeHieuSuatLamViec
            // 
            mnuThongKeHieuSuatLamViec.Name = "mnuThongKeHieuSuatLamViec";
            mnuThongKeHieuSuatLamViec.Size = new Size(283, 26);
            mnuThongKeHieuSuatLamViec.Text = "Thống kê Năng suất làm việc";
            mnuThongKeHieuSuatLamViec.Click += mnuThongKeHieuSuatLamViec_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(280, 6);
            // 
            // mnuLichSuHeThong
            // 
            mnuLichSuHeThong.Name = "mnuLichSuHeThong";
            mnuLichSuHeThong.Size = new Size(283, 26);
            mnuLichSuHeThong.Text = "Lịch sử hệ thống";
            mnuLichSuHeThong.Click += mnuLichSuHeThong_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, thôngTinPhầnMềmToolStripMenuItem, toolStripSeparator4, mnuCauHinh });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F11;
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(289, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(289, 26);
            thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(286, 6);
            // 
            // mnuCauHinh
            // 
            mnuCauHinh.Name = "mnuCauHinh";
            mnuCauHinh.Size = new Size(289, 26);
            mnuCauHinh.Text = "Cấu hình";
            mnuCauHinh.Click += mnuCauHinh_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet_Click });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(118, 20);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(586, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet_Click
            // 
            lblLienKet_Click.Name = "lblLienKet_Click";
            lblLienKet_Click.Size = new Size(81, 20);
            lblLienKet_Click.Text = "© 2026 FIT";
            lblLienKet_Click.Click += lblLienKet_Click_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quản lý Lịch làm việc";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuDiaDiem;
        private ToolStripMenuItem mnuLichLamViec;
        private ToolStripMenuItem mnuPhanCong;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuTaiKhoan;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeLichLamViec;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet_Click;
        private ToolStripMenuItem mnuTienDoCongViec;
        private ToolStripMenuItem mnuThongKeTienDoCongViec;
        private ToolStripMenuItem mnuThongKeHieuSuatLamViec;
        private ToolStripMenuItem mnuThongKeChiTietCongViec;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuLichSuHeThong;
        private ToolStripMenuItem mnuLoaiCongViec;
        private ToolStripMenuItem mnuTrangChu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuCauHinh;
    }
}