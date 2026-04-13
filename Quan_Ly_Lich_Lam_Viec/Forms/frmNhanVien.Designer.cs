namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            cboMaChucVu = new ComboBox();
            cboMaPhong = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            MaChucVu = new DataGridViewTextBoxColumn();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 242, 242);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1163, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(cboMaChucVu);
            panel1.Controls.Add(cboMaPhong);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtHoVaTen);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(30, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 165);
            panel1.TabIndex = 40;
            // 
            // cboMaChucVu
            // 
            cboMaChucVu.BackColor = Color.FromArgb(242, 242, 242);
            cboMaChucVu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboMaChucVu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMaChucVu.FormattingEnabled = true;
            cboMaChucVu.Location = new Point(518, 85);
            cboMaChucVu.Name = "cboMaChucVu";
            cboMaChucVu.Size = new Size(197, 25);
            cboMaChucVu.TabIndex = 26;
            // 
            // cboMaPhong
            // 
            cboMaPhong.BackColor = Color.FromArgb(242, 242, 242);
            cboMaPhong.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboMaPhong.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMaPhong.FormattingEnabled = true;
            cboMaPhong.Location = new Point(518, 45);
            cboMaPhong.Name = "cboMaPhong";
            cboMaPhong.Size = new Size(197, 25);
            cboMaPhong.TabIndex = 25;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.BackColor = Color.FromArgb(242, 242, 242);
            dtpNgaySinh.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpNgaySinh.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(125, 46);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(230, 24);
            dtpNgaySinh.TabIndex = 24;
            dtpNgaySinh.Value = new DateTime(2026, 1, 30, 12, 55, 19, 0);
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(242, 242, 242);
            txtDiaChi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiaChi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDiaChi.Location = new Point(125, 127);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(590, 24);
            txtDiaChi.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(242, 242, 242);
            txtEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEmail.Location = new Point(125, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 24);
            txtEmail.TabIndex = 22;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.FromArgb(242, 242, 242);
            txtSDT.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSDT.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtSDT.Location = new Point(518, 11);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(197, 24);
            txtSDT.TabIndex = 21;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.FromArgb(242, 242, 242);
            txtHoVaTen.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoVaTen.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtHoVaTen.Location = new Point(125, 11);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(230, 24);
            txtHoVaTen.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 242, 242);
            label6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label6.Location = new Point(398, 92);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 18;
            label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(242, 242, 242);
            label5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label5.Location = new Point(398, 56);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 17;
            label5.Text = "Tên phòng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(242, 242, 242);
            label7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label7.Location = new Point(2, 133);
            label7.Name = "label7";
            label7.Size = new Size(58, 18);
            label7.TabIndex = 16;
            label7.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(2, 94);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 19;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 242, 242);
            label4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label4.Location = new Point(398, 16);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(2, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 13;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(2, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 12;
            label1.Text = "Họ và tên (*):";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(242, 242, 242);
            btnXuat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXuat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXuat.Location = new Point(973, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(107, 37);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(242, 242, 242);
            btnNhap.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnNhap.Location = new Point(973, 57);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 37);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(860, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 37);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(860, 57);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 37);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(242, 242, 242);
            btnTimKiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTimKiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTimKiem.Location = new Point(973, 14);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 37);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(759, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 37);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(860, 14);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 37);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(759, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 37);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(759, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 37);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(0, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1163, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, NgaySinh, Email, SoDienThoai, DiaChi, MaPhong, MaChucVu });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView.Location = new Point(3, 20);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1157, 284);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "MaPhong";
            MaPhong.HeaderText = "Phòng ban";
            MaPhong.MinimumWidth = 6;
            MaPhong.Name = "MaPhong";
            // 
            // MaChucVu
            // 
            MaChucVu.DataPropertyName = "MaChucVu";
            MaChucVu.HeaderText = "Chức vụ";
            MaChucVu.MinimumWidth = 6;
            MaChucVu.Name = "MaChucVu";
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.BackColor = Color.FromArgb(242, 242, 242);
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            grBoxDanhSachLog.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grBoxDanhSachLog.Location = new Point(0, 392);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(1163, 131);
            grBoxDanhSachLog.TabIndex = 2;
            grBoxDanhSachLog.TabStop = false;
            grBoxDanhSachLog.Text = "Danh sách log";
            grBoxDanhSachLog.Visible = false;
            // 
            // lstLog
            // 
            lstLog.BackColor = Color.FromArgb(242, 242, 242);
            lstLog.Dock = DockStyle.Fill;
            lstLog.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lstLog.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 17;
            lstLog.Location = new Point(3, 20);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(1157, 108);
            lstLog.TabIndex = 0;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 523);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            WindowState = FormWindowState.Maximized;
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaChucVu;
        private GroupBox grBoxDanhSachLog;
        private ListBox lstLog;
        private Panel panel1;
        private ComboBox cboMaChucVu;
        private ComboBox cboMaPhong;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoVaTen;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
    }
}