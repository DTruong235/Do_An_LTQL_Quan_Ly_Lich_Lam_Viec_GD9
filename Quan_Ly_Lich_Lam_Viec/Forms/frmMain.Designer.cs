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
            mnuNghiPhep = new ToolStripMenuItem();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeLichLamViec = new ToolStripMenuItem();
            mnuThongKeChiTietCongViec = new ToolStripMenuItem();
            mnuThongKeTienDoCongViec = new ToolStripMenuItem();
            mnuThongKeHieuSuatLamViec = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuLichSuHeThong = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            mnuHDSD = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuCauHinh = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet_Click = new ToolStripStatusLabel();
            pnlSidebar = new Panel();
            btnDangXuat = new Button();
            btnThongKeHieuSuatLamViec = new Button();
            btnThongKeTienDoCongViec = new Button();
            btnThongKeChiTietCongViec = new Button();
            btnThongKeLichLamViec = new Button();
            btnDonNghiPhep = new Button();
            btnCaiDat = new Button();
            btnTaiKhoan = new Button();
            btnNhanVien = new Button();
            btnLichLamViec = new Button();
            btnDashboard = new Button();
            panelSubSidebar = new Panel();
            picSide = new PictureBox();
            pnlName_Sidebar = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            panelSubSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSide).BeginInit();
            pnlName_Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1297, 28);
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
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuTrangChu, mnuDiaDiem, mnuLichLamViec, mnuPhanCong, mnuTienDoCongViec, mnuLoaiCongViec, toolStripSeparator2, mnuNhanVien, mnuNghiPhep, mnuTaiKhoan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(73, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuTrangChu
            // 
            mnuTrangChu.Name = "mnuTrangChu";
            mnuTrangChu.Size = new Size(209, 26);
            mnuTrangChu.Text = "Màn hình chính...";
            mnuTrangChu.Click += mnuTrangChu_Click;
            // 
            // mnuDiaDiem
            // 
            mnuDiaDiem.Name = "mnuDiaDiem";
            mnuDiaDiem.Size = new Size(209, 26);
            mnuDiaDiem.Text = "Địa điểm";
            mnuDiaDiem.Click += mnuDiaDiem_Click;
            // 
            // mnuLichLamViec
            // 
            mnuLichLamViec.Name = "mnuLichLamViec";
            mnuLichLamViec.Size = new Size(209, 26);
            mnuLichLamViec.Text = "Lịch làm việc";
            mnuLichLamViec.Click += mnuLichLamViec_Click;
            // 
            // mnuPhanCong
            // 
            mnuPhanCong.Name = "mnuPhanCong";
            mnuPhanCong.Size = new Size(209, 26);
            mnuPhanCong.Text = "Phân công";
            mnuPhanCong.Click += mnuPhanCong_Click;
            // 
            // mnuTienDoCongViec
            // 
            mnuTienDoCongViec.Name = "mnuTienDoCongViec";
            mnuTienDoCongViec.Size = new Size(209, 26);
            mnuTienDoCongViec.Text = "Tiến độ công việc";
            mnuTienDoCongViec.Click += mnuTienDoCongViec_Click;
            // 
            // mnuLoaiCongViec
            // 
            mnuLoaiCongViec.Name = "mnuLoaiCongViec";
            mnuLoaiCongViec.Size = new Size(209, 26);
            mnuLoaiCongViec.Text = "Loại công việc";
            mnuLoaiCongViec.Click += mnuLoaiCongViec_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(206, 6);
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(209, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuNghiPhep
            // 
            mnuNghiPhep.Name = "mnuNghiPhep";
            mnuNghiPhep.Size = new Size(209, 26);
            mnuNghiPhep.Text = "Nghỉ phép";
            mnuNghiPhep.Click += mnuNghiPhep_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(209, 26);
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
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuHDSD, thôngTinPhầnMềmToolStripMenuItem, toolStripSeparator4, mnuCauHinh });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuHDSD
            // 
            mnuHDSD.Name = "mnuHDSD";
            mnuHDSD.ShortcutKeys = Keys.Control | Keys.F11;
            mnuHDSD.Size = new Size(289, 26);
            mnuHDSD.Text = "Hướng dẫn sử dụng";
            mnuHDSD.Click += mnuHDSD_Click;
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
            statusStrip1.Location = new Point(0, 920);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1297, 26);
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
            toolStripStatusLabel1.Size = new Size(1081, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet_Click
            // 
            lblLienKet_Click.Name = "lblLienKet_Click";
            lblLienKet_Click.Size = new Size(81, 20);
            lblLienKet_Click.Text = "© 2026 FIT";
            lblLienKet_Click.Click += lblLienKet_Click_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnThongKeHieuSuatLamViec);
            pnlSidebar.Controls.Add(btnThongKeTienDoCongViec);
            pnlSidebar.Controls.Add(btnThongKeChiTietCongViec);
            pnlSidebar.Controls.Add(btnThongKeLichLamViec);
            pnlSidebar.Controls.Add(btnDonNghiPhep);
            pnlSidebar.Controls.Add(btnCaiDat);
            pnlSidebar.Controls.Add(btnTaiKhoan);
            pnlSidebar.Controls.Add(btnNhanVien);
            pnlSidebar.Controls.Add(btnLichLamViec);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(panelSubSidebar);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 28);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(252, 892);
            pnlSidebar.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(0, 662);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(252, 46);
            btnDangXuat.TabIndex = 14;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKeHieuSuatLamViec
            // 
            btnThongKeHieuSuatLamViec.Location = new Point(0, 442);
            btnThongKeHieuSuatLamViec.Name = "btnThongKeHieuSuatLamViec";
            btnThongKeHieuSuatLamViec.Size = new Size(252, 58);
            btnThongKeHieuSuatLamViec.TabIndex = 12;
            btnThongKeHieuSuatLamViec.Text = "Thống kê hiệu suất làm việc";
            btnThongKeHieuSuatLamViec.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeHieuSuatLamViec.UseVisualStyleBackColor = true;
            btnThongKeHieuSuatLamViec.Click += btnThongKeHieuSuatLamViec_Click;
            // 
            // btnThongKeTienDoCongViec
            // 
            btnThongKeTienDoCongViec.Location = new Point(0, 384);
            btnThongKeTienDoCongViec.Name = "btnThongKeTienDoCongViec";
            btnThongKeTienDoCongViec.Size = new Size(252, 58);
            btnThongKeTienDoCongViec.TabIndex = 11;
            btnThongKeTienDoCongViec.Text = "Thống kê tiến độ công việc";
            btnThongKeTienDoCongViec.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeTienDoCongViec.UseVisualStyleBackColor = true;
            btnThongKeTienDoCongViec.Click += btnThongKeTienDoCongViec_Click;
            // 
            // btnThongKeChiTietCongViec
            // 
            btnThongKeChiTietCongViec.Location = new Point(0, 326);
            btnThongKeChiTietCongViec.Name = "btnThongKeChiTietCongViec";
            btnThongKeChiTietCongViec.Size = new Size(252, 58);
            btnThongKeChiTietCongViec.TabIndex = 10;
            btnThongKeChiTietCongViec.Text = "Thống kê chi tiết công việc";
            btnThongKeChiTietCongViec.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeChiTietCongViec.UseVisualStyleBackColor = true;
            btnThongKeChiTietCongViec.Click += btnThongKeChiTietCongViec_Click;
            // 
            // btnThongKeLichLamViec
            // 
            btnThongKeLichLamViec.Location = new Point(0, 280);
            btnThongKeLichLamViec.Name = "btnThongKeLichLamViec";
            btnThongKeLichLamViec.Size = new Size(252, 46);
            btnThongKeLichLamViec.TabIndex = 9;
            btnThongKeLichLamViec.Text = "Thống kê lịch làm việc";
            btnThongKeLichLamViec.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeLichLamViec.UseVisualStyleBackColor = true;
            btnThongKeLichLamViec.Click += btnThongKeLichLamViec_Click;
            // 
            // btnDonNghiPhep
            // 
            btnDonNghiPhep.Location = new Point(3, 506);
            btnDonNghiPhep.Name = "btnDonNghiPhep";
            btnDonNghiPhep.Size = new Size(252, 46);
            btnDonNghiPhep.TabIndex = 13;
            btnDonNghiPhep.Text = "Nghỉ phép";
            btnDonNghiPhep.TextAlign = ContentAlignment.MiddleLeft;
            btnDonNghiPhep.UseVisualStyleBackColor = true;
            btnDonNghiPhep.Click += btnDonNghiPhep_Click;
            // 
            // btnCaiDat
            // 
            btnCaiDat.Location = new Point(0, 610);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.Size = new Size(252, 46);
            btnCaiDat.TabIndex = 7;
            btnCaiDat.Text = "Cài đặt";
            btnCaiDat.TextAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.UseVisualStyleBackColor = true;
            btnCaiDat.Click += btnCaiDat_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Location = new Point(0, 558);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(252, 46);
            btnTaiKhoan.TabIndex = 6;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(0, 234);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(252, 46);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += mnuNhanVien_Click;
            // 
            // btnLichLamViec
            // 
            btnLichLamViec.Location = new Point(0, 188);
            btnLichLamViec.Name = "btnLichLamViec";
            btnLichLamViec.Size = new Size(252, 46);
            btnLichLamViec.TabIndex = 2;
            btnLichLamViec.Text = "Lịch làm việc";
            btnLichLamViec.TextAlign = ContentAlignment.MiddleLeft;
            btnLichLamViec.UseVisualStyleBackColor = true;
            btnLichLamViec.Click += mnuLichLamViec_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 142);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(252, 46);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelSubSidebar
            // 
            panelSubSidebar.Controls.Add(picSide);
            panelSubSidebar.Controls.Add(pnlName_Sidebar);
            panelSubSidebar.Dock = DockStyle.Top;
            panelSubSidebar.Location = new Point(0, 0);
            panelSubSidebar.Name = "panelSubSidebar";
            panelSubSidebar.Size = new Size(252, 88);
            panelSubSidebar.TabIndex = 0;
            // 
            // picSide
            // 
            picSide.BackColor = SystemColors.HighlightText;
            picSide.Dock = DockStyle.Fill;
            picSide.Image = Properties.Resources.app_icon;
            picSide.Location = new Point(0, 0);
            picSide.Name = "picSide";
            picSide.Size = new Size(106, 88);
            picSide.SizeMode = PictureBoxSizeMode.Zoom;
            picSide.TabIndex = 2;
            picSide.TabStop = false;
            // 
            // pnlName_Sidebar
            // 
            pnlName_Sidebar.Controls.Add(label2);
            pnlName_Sidebar.Controls.Add(label1);
            pnlName_Sidebar.Dock = DockStyle.Right;
            pnlName_Sidebar.Location = new Point(106, 0);
            pnlName_Sidebar.Name = "pnlName_Sidebar";
            pnlName_Sidebar.Size = new Size(146, 88);
            pnlName_Sidebar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 0;
            label2.Text = "Lịch làm việc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            err.SetIconAlignment(label1, ErrorIconAlignment.TopLeft);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Quản lý";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(252, 28);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1045, 892);
            panelMain.TabIndex = 6;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 946);
            Controls.Add(panelMain);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quản lý Lịch làm việc";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            panelSubSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSide).EndInit();
            pnlName_Sidebar.ResumeLayout(false);
            pnlName_Sidebar.PerformLayout();
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
        private ToolStripMenuItem mnuHDSD;
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
        private Panel pnlSidebar;
        private Panel panelMain;
        private Button btnNhanVien;
        private Button btnLichLamViec;
        private Button btnDashboard;
        private Panel panelSubSidebar;
        private PictureBox picSide;
        private Panel pnlName_Sidebar;
        private Label label2;
        private Label label1;
        private Button btnCaiDat;
        private Button btnTaiKhoan;
        private ToolStripMenuItem mnuNghiPhep;
        private Button btnDonNghiPhep;
        private Button btnThongKeLichLamViec;
        private Button btnThongKeHieuSuatLamViec;
        private Button btnThongKeTienDoCongViec;
        private Button btnThongKeChiTietCongViec;
        private Button btnDangXuat;
    }
}