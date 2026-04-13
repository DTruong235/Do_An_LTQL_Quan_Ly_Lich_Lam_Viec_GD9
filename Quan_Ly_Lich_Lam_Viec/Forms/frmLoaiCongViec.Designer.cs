namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmLoaiCongViec
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaLoaiCV = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 242, 242);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin địa điểm";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(btnXuat);
            panel3.Controls.Add(btnNhap);
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnHuyBo);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(txtTenLoai);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(59, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 211);
            panel3.TabIndex = 38;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(242, 242, 242);
            btnXuat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXuat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXuat.Location = new Point(446, 124);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(119, 40);
            btnXuat.TabIndex = 15;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(242, 242, 242);
            btnNhap.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnNhap.Location = new Point(306, 124);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 40);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(446, 66);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 40);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(168, 124);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 40);
            btnHuyBo.TabIndex = 18;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(242, 242, 242);
            btnTimKiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTimKiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTimKiem.Location = new Point(31, 171);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(534, 40);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(306, 66);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(168, 66);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 40);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(31, 124);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 40);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(31, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 40);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.BackColor = Color.FromArgb(242, 242, 242);
            txtTenLoai.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTenLoai.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtTenLoai.Location = new Point(168, 5);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(397, 24);
            txtTenLoai.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 13;
            label1.Text = "Tên loại công việc:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(0, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 322);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách địa điểm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLoaiCV, TenLoai });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView.Location = new Point(3, 20);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(680, 299);
            dataGridView.TabIndex = 0;
            // 
            // MaLoaiCV
            // 
            MaLoaiCV.DataPropertyName = "MaLoaiCV";
            MaLoaiCV.HeaderText = "Mã loại công việc";
            MaLoaiCV.MinimumWidth = 6;
            MaLoaiCV.Name = "MaLoaiCV";
            MaLoaiCV.ReadOnly = true;
            MaLoaiCV.Visible = false;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên loại công việc";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.BackColor = Color.FromArgb(242, 242, 242);
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            grBoxDanhSachLog.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grBoxDanhSachLog.Location = new Point(0, 442);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(686, 139);
            grBoxDanhSachLog.TabIndex = 3;
            grBoxDanhSachLog.TabStop = false;
            grBoxDanhSachLog.Text = "Danh sách log";
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
            lstLog.Size = new Size(680, 116);
            lstLog.TabIndex = 0;
            // 
            // frmLoaiCongViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 581);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiCongViec";
            Text = "Loại công việc";
            WindowState = FormWindowState.Maximized;
            Load += frmLoaiCongViec_Load;
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaLoaiCV;
        private DataGridViewTextBoxColumn TenLoai;
        private GroupBox grBoxDanhSachLog;
        private ListBox lstLog;
        private Panel panel3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private Label label1;
    }
}