namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmPhanCong
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
            panel1 = new Panel();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkXacNhan = new CheckBox();
            cboNhanVien = new ComboBox();
            cboVaiTro = new ComboBox();
            cboLichLamViec = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaPhanCong = new DataGridViewTextBoxColumn();
            MaLich = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            Vai_Tro = new DataGridViewTextBoxColumn();
            Da_Xac_Nhan = new DataGridViewTextBoxColumn();
            GiaoViec = new DataGridViewLinkColumn();
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
            groupBox1.Size = new Size(1207, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phân công";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chkXacNhan);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(cboVaiTro);
            panel1.Controls.Add(cboLichLamViec);
            panel1.Location = new Point(37, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 137);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(1020, 51);
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
            btnHuyBo.Location = new Point(722, 51);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 40);
            btnHuyBo.TabIndex = 18;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(1020, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(871, 51);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 40);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(871, 1);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 40);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(722, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 40);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(362, 61);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 14;
            label3.Text = "Vai trò (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(5, 67);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 15;
            label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 16;
            label1.Text = "Chọn lịch (*):";
            // 
            // chkXacNhan
            // 
            chkXacNhan.AutoSize = true;
            chkXacNhan.BackColor = Color.FromArgb(242, 242, 242);
            chkXacNhan.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkXacNhan.ForeColor = Color.FromArgb(222, 0, 0, 0);
            chkXacNhan.Location = new Point(453, 100);
            chkXacNhan.Name = "chkXacNhan";
            chkXacNhan.Size = new Size(111, 22);
            chkXacNhan.TabIndex = 13;
            chkXacNhan.Text = "Đã xác nhận";
            chkXacNhan.UseVisualStyleBackColor = false;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(242, 242, 242);
            cboNhanVien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboNhanVien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(145, 58);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(169, 25);
            cboNhanVien.TabIndex = 10;
            // 
            // cboVaiTro
            // 
            cboVaiTro.BackColor = Color.FromArgb(242, 242, 242);
            cboVaiTro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboVaiTro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Chủ trì", "Thư ký", "Thành viên", "Hỗ trợ" });
            cboVaiTro.Location = new Point(453, 60);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(169, 25);
            cboVaiTro.TabIndex = 11;
            cboVaiTro.SelectedIndexChanged += cboVaiTro_SelectedIndexChanged;
            // 
            // cboLichLamViec
            // 
            cboLichLamViec.BackColor = Color.FromArgb(242, 242, 242);
            cboLichLamViec.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboLichLamViec.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLichLamViec.FormattingEnabled = true;
            cboLichLamViec.Location = new Point(145, 3);
            cboLichLamViec.Name = "cboLichLamViec";
            cboLichLamViec.Size = new Size(477, 25);
            cboLichLamViec.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(0, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1207, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân sự tham gia";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaPhanCong, MaLich, MaNhanVien, Vai_Tro, Da_Xac_Nhan, GiaoViec });
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
            dataGridView.Size = new Size(1201, 136);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaPhanCong
            // 
            MaPhanCong.DataPropertyName = "MaPhanCong";
            MaPhanCong.HeaderText = "Mã phân công";
            MaPhanCong.MinimumWidth = 6;
            MaPhanCong.Name = "MaPhanCong";
            MaPhanCong.ReadOnly = true;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.HeaderText = "Tên lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // Vai_Tro
            // 
            Vai_Tro.DataPropertyName = "Vai_Tro";
            Vai_Tro.HeaderText = "Vai trò";
            Vai_Tro.MinimumWidth = 6;
            Vai_Tro.Name = "Vai_Tro";
            Vai_Tro.ReadOnly = true;
            // 
            // Da_Xac_Nhan
            // 
            Da_Xac_Nhan.DataPropertyName = "Da_Xac_Nhan";
            Da_Xac_Nhan.HeaderText = "Xác nhận";
            Da_Xac_Nhan.MinimumWidth = 6;
            Da_Xac_Nhan.Name = "Da_Xac_Nhan";
            Da_Xac_Nhan.ReadOnly = true;
            // 
            // GiaoViec
            // 
            GiaoViec.DataPropertyName = "GiaoViec";
            GiaoViec.HeaderText = "Giao việc";
            GiaoViec.MinimumWidth = 6;
            GiaoViec.Name = "GiaoViec";
            GiaoViec.ReadOnly = true;
            GiaoViec.Resizable = DataGridViewTriState.True;
            GiaoViec.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmPhanCong
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 346);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhanCong";
            Text = "Phân công";
            Load += frmPhanCong_Load;
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
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaPhanCong;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn Vai_Tro;
        private DataGridViewTextBoxColumn Da_Xac_Nhan;
        private DataGridViewLinkColumn GiaoViec;
        private Panel panel1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkXacNhan;
        private ComboBox cboNhanVien;
        private ComboBox cboVaiTro;
        private ComboBox cboLichLamViec;
    }
}