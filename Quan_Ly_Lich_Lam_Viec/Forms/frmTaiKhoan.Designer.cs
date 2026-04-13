namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmTaiKhoan
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
            panel2 = new Panel();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkTrangThai = new CheckBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            cboQuyen = new ComboBox();
            cboNhanVien = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            MaQuyen = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 242, 242);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Tài khoản";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(chkTrangThai);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(cboQuyen);
            panel2.Controls.Add(cboNhanVien);
            panel2.Location = new Point(42, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 243);
            panel2.TabIndex = 42;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(536, 119);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 40);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(536, 73);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 40);
            btnHuyBo.TabIndex = 23;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(242, 242, 242);
            btnTimKiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTimKiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTimKiem.Location = new Point(410, 165);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(246, 40);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(408, 119);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(536, 27);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 40);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(408, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 40);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(408, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 40);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 242, 242);
            label4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label4.Location = new Point(3, 164);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 18;
            label4.Text = "Quyền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 19;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 20;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(3, 119);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 21;
            label1.Text = "Mật khẩu:";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.BackColor = Color.FromArgb(242, 242, 242);
            chkTrangThai.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkTrangThai.ForeColor = Color.FromArgb(222, 0, 0, 0);
            chkTrangThai.Location = new Point(134, 207);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(96, 22);
            chkTrangThai.TabIndex = 17;
            chkTrangThai.Text = "Trạng thái";
            chkTrangThai.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(242, 242, 242);
            txtMatKhau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatKhau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtMatKhau.Location = new Point(134, 111);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(217, 24);
            txtMatKhau.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.FromArgb(242, 242, 242);
            txtTenDangNhap.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTenDangNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtTenDangNhap.Location = new Point(134, 57);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(217, 24);
            txtTenDangNhap.TabIndex = 16;
            // 
            // cboQuyen
            // 
            cboQuyen.BackColor = Color.FromArgb(242, 242, 242);
            cboQuyen.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboQuyen.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Items.AddRange(new object[] { "Admin", "Nhân viên" });
            cboQuyen.Location = new Point(134, 160);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(217, 25);
            cboQuyen.TabIndex = 13;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(242, 242, 242);
            cboNhanVien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboNhanVien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(134, 7);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(217, 25);
            cboNhanVien.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(242, 242, 242);
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox3.Location = new Point(0, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(738, 245);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Tài khoản";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, Username, Password, MaQuyen, TrangThai });
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
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(732, 222);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Tên nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Tên đăng nhập";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // MaQuyen
            // 
            MaQuyen.DataPropertyName = "MaQuyen";
            MaQuyen.HeaderText = "Quyền hạn";
            MaQuyen.MinimumWidth = 6;
            MaQuyen.Name = "MaQuyen";
            MaQuyen.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 544);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmTaiKhoan";
            Text = "Tài khoản";
            WindowState = FormWindowState.Maximized;
            Load += frmTaiKhoan_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn MaQuyen;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel panel2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkTrangThai;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private ComboBox cboQuyen;
        private ComboBox cboNhanVien;
    }
}