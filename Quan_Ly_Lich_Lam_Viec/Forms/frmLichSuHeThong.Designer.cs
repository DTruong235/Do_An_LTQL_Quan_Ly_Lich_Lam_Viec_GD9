namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmLichSuHeThong
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
            panel2 = new Panel();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            cboNhanVien = new ComboBox();
            btnLamMoi = new Button();
            btnLoc = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            MaLog = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HanhDong = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 132);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(dtpDenNgay);
            panel2.Controls.Add(dtpTuNgay);
            panel2.Controls.Add(cboNhanVien);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnLoc);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(51, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 101);
            panel2.TabIndex = 36;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.BackColor = Color.FromArgb(242, 242, 242);
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDenNgay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDenNgay.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(368, 63);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(183, 24);
            dtpDenNgay.TabIndex = 13;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.BackColor = Color.FromArgb(242, 242, 242);
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpTuNgay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpTuNgay.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(82, 64);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(183, 24);
            dtpTuNgay.TabIndex = 14;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(242, 242, 242);
            cboNhanVien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboNhanVien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(260, 14);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(370, 25);
            cboNhanVien.TabIndex = 12;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(242, 242, 242);
            btnLamMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLamMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLamMoi.Location = new Point(682, 55);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 33);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(242, 242, 242);
            btnLoc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLoc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLoc.Location = new Point(570, 55);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(106, 33);
            btnLoc.TabIndex = 11;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(277, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 7;
            label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(161, 21);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 8;
            label3.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(3, 69);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 9;
            label1.Text = "Từ ngày:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 242, 242);
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(0, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 386);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử hệ thống";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLog, MaNhanVien, HanhDong, ChiTiet, ThoiGian });
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
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(894, 363);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaLog
            // 
            MaLog.DataPropertyName = "MaLog";
            MaLog.HeaderText = "Mã Log";
            MaLog.MinimumWidth = 6;
            MaLog.Name = "MaLog";
            MaLog.ReadOnly = true;
            MaLog.Visible = false;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Họ tên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // HanhDong
            // 
            HanhDong.DataPropertyName = "HanhDong";
            HanhDong.HeaderText = "Hành động";
            HanhDong.MinimumWidth = 6;
            HanhDong.Name = "HanhDong";
            HanhDong.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.MinimumWidth = 6;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // frmLichSuHeThong
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmLichSuHeThong";
            Text = "Lịch sử hệ thống";
            WindowState = FormWindowState.Maximized;
            Load += frmLichSuHeThong_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaLog;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HanhDong;
        private DataGridViewTextBoxColumn ChiTiet;
        private DataGridViewTextBoxColumn ThoiGian;
        private Panel panel2;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private ComboBox cboNhanVien;
        private Button btnLamMoi;
        private Button btnLoc;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}