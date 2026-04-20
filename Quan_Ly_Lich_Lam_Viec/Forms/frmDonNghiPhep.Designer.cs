namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDonNghiPhep
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            btnIn = new Button();
            btnTuChoi = new Button();
            btnDuyet = new Button();
            btnThem = new Button();
            txtLyDo = new TextBox();
            label2 = new Label();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoTenNV = new DataGridViewTextBoxColumn();
            NgayBD = new DataGridViewTextBoxColumn();
            NgayKT = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 331);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(900, 331);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Đơn nghỉ phép";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(btnIn);
            panel3.Controls.Add(btnTuChoi);
            panel3.Controls.Add(btnDuyet);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(txtLyDo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dtpKetThuc);
            panel3.Controls.Add(dtpBatDau);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cboNhanVien);
            panel3.Location = new Point(79, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 273);
            panel3.TabIndex = 0;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(242, 242, 242);
            btnIn.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnIn.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnIn.Location = new Point(445, 218);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(144, 38);
            btnIn.TabIndex = 20;
            btnIn.Text = "In đơn nghỉ phép";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.BackColor = Color.FromArgb(242, 242, 242);
            btnTuChoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTuChoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTuChoi.Location = new Point(317, 218);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(105, 38);
            btnTuChoi.TabIndex = 20;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnDuyet
            // 
            btnDuyet.BackColor = Color.FromArgb(242, 242, 242);
            btnDuyet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnDuyet.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnDuyet.Location = new Point(163, 218);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(129, 38);
            btnDuyet.TabIndex = 20;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(18, 218);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 38);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(174, 162);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(418, 30);
            txtLyDo.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 170);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 34;
            label2.Text = "Lý do:";
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.BackColor = Color.FromArgb(242, 242, 242);
            dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpKetThuc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpKetThuc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.Location = new Point(174, 112);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(414, 24);
            dtpKetThuc.TabIndex = 32;
            // 
            // dtpBatDau
            // 
            dtpBatDau.BackColor = Color.FromArgb(242, 242, 242);
            dtpBatDau.CustomFormat = "dd/MM/yyyy";
            dtpBatDau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpBatDau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(174, 62);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(415, 24);
            dtpBatDau.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 242, 242);
            label6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label6.Location = new Point(3, 118);
            label6.Name = "label6";
            label6.Size = new Size(132, 18);
            label6.TabIndex = 30;
            label6.Text = "Thời gian kết thúc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 29;
            label3.Text = "Thời gian bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(174, 3);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(415, 31);
            cboNhanVien.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 331);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 187);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách Đơn xin nghỉ phép";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoTenNV, NgayBD, NgayKT, LyDo, TrangThai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(894, 158);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // HoTenNV
            // 
            HoTenNV.DataPropertyName = "HoTen";
            HoTenNV.HeaderText = "Nhân viên";
            HoTenNV.MinimumWidth = 6;
            HoTenNV.Name = "HoTenNV";
            HoTenNV.ReadOnly = true;
            // 
            // NgayBD
            // 
            NgayBD.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            NgayBD.DefaultCellStyle = dataGridViewCellStyle1;
            NgayBD.HeaderText = "Ngày bắt đầu";
            NgayBD.MinimumWidth = 6;
            NgayBD.Name = "NgayBD";
            NgayBD.ReadOnly = true;
            // 
            // NgayKT
            // 
            NgayKT.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            NgayKT.DefaultCellStyle = dataGridViewCellStyle2;
            NgayKT.HeaderText = "Ngày kết thúc";
            NgayKT.MinimumWidth = 6;
            NgayKT.Name = "NgayKT";
            NgayKT.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý do";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // frmDonNghiPhep
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDonNghiPhep";
            Text = "Đơn nghỉ phép";
            Load += frmDonNghiPhep_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private ComboBox cboNhanVien;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Label label6;
        private Label label3;
        private TextBox txtLyDo;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnTuChoi;
        private Button btnDuyet;
        private Button btnThem;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button btnIn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoTenNV;
        private DataGridViewTextBoxColumn NgayBD;
        private DataGridViewTextBoxColumn NgayKT;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThai;
    }
}