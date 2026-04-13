namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmTienDoCongViec
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            lblTrangThai = new Label();
            label2 = new Label();
            progressBar = new ProgressBar();
            txtGhiChu = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cboTenLich = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaTienDo = new DataGridViewTextBoxColumn();
            MaLich = new DataGridViewTextBoxColumn();
            PhanTramHoanThanh = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            NgayCapNhat = new DataGridViewTextBoxColumn();
            checkedListBox = new CheckedListBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            groupBox1.Size = new Size(1105, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công việc";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(lblTrangThai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboTenLich);
            panel1.Location = new Point(76, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 161);
            panel1.TabIndex = 44;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(750, 104);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(158, 40);
            btnThoat.TabIndex = 38;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(578, 104);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(154, 40);
            btnHuyBo.TabIndex = 39;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(212, 104);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(167, 40);
            btnXoa.TabIndex = 40;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(395, 104);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(164, 40);
            btnLuu.TabIndex = 41;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(36, 104);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(156, 40);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.BackColor = Color.FromArgb(242, 242, 242);
            lblTrangThai.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTrangThai.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTrangThai.Location = new Point(730, 11);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(86, 18);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(636, 11);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 36;
            label2.Text = "Tiến độ:";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(242, 242, 242);
            progressBar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            progressBar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            progressBar.Location = new Point(636, 45);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(272, 33);
            progressBar.TabIndex = 35;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = Color.FromArgb(242, 242, 242);
            txtGhiChu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGhiChu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtGhiChu.Location = new Point(89, 52);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(473, 24);
            txtGhiChu.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(2, 52);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 25;
            label3.Text = "Ghi chú: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(2, 7);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 26;
            label1.Text = "Tên lịch:";
            // 
            // cboTenLich
            // 
            cboTenLich.BackColor = Color.FromArgb(242, 242, 242);
            cboTenLich.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboTenLich.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTenLich.FormattingEnabled = true;
            cboTenLich.Location = new Point(89, 6);
            cboTenLich.Name = "cboTenLich";
            cboTenLich.Size = new Size(470, 25);
            cboTenLich.TabIndex = 22;
            cboTenLich.SelectedIndexChanged += cboTenLich_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(checkedListBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(0, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1105, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách công việc";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaTienDo, MaLich, PhanTramHoanThanh, GhiChu, NgayCapNhat });
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
            dataGridView.Location = new Point(310, 20);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(792, 282);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // MaTienDo
            // 
            MaTienDo.DataPropertyName = "MaTienDo";
            MaTienDo.FillWeight = 40.70932F;
            MaTienDo.HeaderText = "Mã tiến độ";
            MaTienDo.MinimumWidth = 6;
            MaTienDo.Name = "MaTienDo";
            MaTienDo.ReadOnly = true;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.FillWeight = 91.23346F;
            MaLich.HeaderText = "Tên lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // PhanTramHoanThanh
            // 
            PhanTramHoanThanh.DataPropertyName = "PhanTramHoanThanh";
            PhanTramHoanThanh.FillWeight = 89.0347443F;
            PhanTramHoanThanh.HeaderText = "Tiến độ";
            PhanTramHoanThanh.MinimumWidth = 6;
            PhanTramHoanThanh.Name = "PhanTramHoanThanh";
            PhanTramHoanThanh.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.FillWeight = 172.070572F;
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // NgayCapNhat
            // 
            NgayCapNhat.DataPropertyName = "NgayCapNhat";
            NgayCapNhat.FillWeight = 106.951859F;
            NgayCapNhat.HeaderText = "Ngày cập nhật";
            NgayCapNhat.MinimumWidth = 6;
            NgayCapNhat.Name = "NgayCapNhat";
            NgayCapNhat.ReadOnly = true;
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.FromArgb(242, 242, 242);
            checkedListBox.Dock = DockStyle.Left;
            checkedListBox.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            checkedListBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(3, 20);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(307, 282);
            checkedListBox.TabIndex = 0;
            checkedListBox.ItemCheck += checkedListBox_ItemCheck;
            // 
            // frmTienDoCongViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 518);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTienDoCongViec";
            Text = "Tiến độ công việc";
            WindowState = FormWindowState.Maximized;
            Load += frmTienDoCongViec_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaTienDo;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn PhanTramHoanThanh;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn NgayCapNhat;
        private Panel panel1;
        private Label lblTrangThai;
        private Label label2;
        private ProgressBar progressBar;
        private TextBox txtGhiChu;
        private Label label3;
        private Label label1;
        private ComboBox cboTenLich;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
    }
}