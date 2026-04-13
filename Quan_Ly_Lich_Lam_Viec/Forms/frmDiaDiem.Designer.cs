namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDiaDiem
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaDiaDiem = new DataGridViewTextBoxColumn();
            TenDiaDiem = new DataGridViewTextBoxColumn();
            DiaChiCuThe = new DataGridViewTextBoxColumn();
            ThietBi = new DataGridViewTextBoxColumn();
            SucChua = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtThietBi = new TextBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            numSucChua = new NumericUpDown();
            txtDiaChi = new TextBox();
            txtTenDiaDiem = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSucChua).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(0, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 232);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách địa điểm";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaDiaDiem, TenDiaDiem, DiaChiCuThe, ThietBi, SucChua });
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
            dataGridView.Size = new Size(756, 209);
            dataGridView.TabIndex = 0;
            // 
            // MaDiaDiem
            // 
            MaDiaDiem.DataPropertyName = "MaDiaDiem";
            MaDiaDiem.HeaderText = "Mã địa điểm";
            MaDiaDiem.MinimumWidth = 6;
            MaDiaDiem.Name = "MaDiaDiem";
            MaDiaDiem.ReadOnly = true;
            MaDiaDiem.Visible = false;
            // 
            // TenDiaDiem
            // 
            TenDiaDiem.DataPropertyName = "TenDiaDiem";
            TenDiaDiem.HeaderText = "Tên địa điểm";
            TenDiaDiem.MinimumWidth = 6;
            TenDiaDiem.Name = "TenDiaDiem";
            TenDiaDiem.ReadOnly = true;
            // 
            // DiaChiCuThe
            // 
            DiaChiCuThe.DataPropertyName = "DiaChiCuThe";
            DiaChiCuThe.HeaderText = "Địa điểm";
            DiaChiCuThe.MinimumWidth = 6;
            DiaChiCuThe.Name = "DiaChiCuThe";
            DiaChiCuThe.ReadOnly = true;
            // 
            // ThietBi
            // 
            ThietBi.DataPropertyName = "ThietBi";
            ThietBi.HeaderText = "Thiết bị";
            ThietBi.MinimumWidth = 6;
            ThietBi.Name = "ThietBi";
            ThietBi.ReadOnly = true;
            // 
            // SucChua
            // 
            SucChua.DataPropertyName = "SucChua";
            SucChua.HeaderText = "Sức chứa";
            SucChua.MinimumWidth = 6;
            SucChua.Name = "SucChua";
            SucChua.ReadOnly = true;
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
            groupBox1.Size = new Size(762, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin địa điểm";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txtThietBi);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(numSucChua);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTenDiaDiem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 269);
            panel1.TabIndex = 32;
            // 
            // txtThietBi
            // 
            txtThietBi.BackColor = Color.FromArgb(242, 242, 242);
            txtThietBi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtThietBi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtThietBi.Location = new Point(120, 165);
            txtThietBi.Multiline = true;
            txtThietBi.Name = "txtThietBi";
            txtThietBi.Size = new Size(283, 101);
            txtThietBi.TabIndex = 30;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(242, 242, 242);
            btnXuat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXuat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXuat.Location = new Point(566, 226);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(119, 40);
            btnXuat.TabIndex = 21;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(242, 242, 242);
            btnNhap.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnNhap.Location = new Point(439, 226);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 40);
            btnNhap.TabIndex = 22;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(566, 94);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 40);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(566, 48);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 40);
            btnHuyBo.TabIndex = 24;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(242, 242, 242);
            btnTimKiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTimKiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTimKiem.Location = new Point(439, 159);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(246, 40);
            btnTimKiem.TabIndex = 25;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(439, 94);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(566, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 40);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(439, 48);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 40);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(439, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 40);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // numSucChua
            // 
            numSucChua.BackColor = Color.FromArgb(242, 242, 242);
            numSucChua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            numSucChua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            numSucChua.Location = new Point(120, 110);
            numSucChua.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSucChua.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSucChua.Name = "numSucChua";
            numSucChua.Size = new Size(252, 24);
            numSucChua.TabIndex = 20;
            numSucChua.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(242, 242, 242);
            txtDiaChi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiaChi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDiaChi.Location = new Point(120, 53);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(283, 24);
            txtDiaChi.TabIndex = 18;
            // 
            // txtTenDiaDiem
            // 
            txtTenDiaDiem.BackColor = Color.FromArgb(242, 242, 242);
            txtTenDiaDiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTenDiaDiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtTenDiaDiem.Location = new Point(120, 5);
            txtTenDiaDiem.Name = "txtTenDiaDiem";
            txtTenDiaDiem.Size = new Size(283, 24);
            txtTenDiaDiem.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 242, 242);
            label4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label4.Location = new Point(3, 165);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 17;
            label4.Text = "Thiết bị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(3, 113);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 16;
            label3.Text = "Sức chứa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 15;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 14;
            label1.Text = "Tên địa điểm:";
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.BackColor = Color.FromArgb(242, 242, 242);
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            grBoxDanhSachLog.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grBoxDanhSachLog.Location = new Point(0, 477);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(762, 78);
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
            lstLog.Size = new Size(756, 55);
            lstLog.TabIndex = 0;
            // 
            // frmDiaDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 555);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDiaDiem";
            Text = "Địa điểm";
            WindowState = FormWindowState.Maximized;
            Load += frmDiaDiem_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSucChua).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaDiaDiem;
        private DataGridViewTextBoxColumn TenDiaDiem;
        private DataGridViewTextBoxColumn DiaChiCuThe;
        private DataGridViewTextBoxColumn ThietBi;
        private DataGridViewTextBoxColumn SucChua;
        private GroupBox groupBox1;
        private GroupBox grBoxDanhSachLog;
        private ListBox lstLog;
        private Panel panel1;
        private TextBox txtThietBi;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private NumericUpDown numSucChua;
        private TextBox txtDiaChi;
        private TextBox txtTenDiaDiem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}