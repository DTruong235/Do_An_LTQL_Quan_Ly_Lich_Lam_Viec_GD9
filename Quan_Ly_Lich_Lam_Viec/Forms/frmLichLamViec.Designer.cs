namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmLichLamViec
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
            groupBox3 = new GroupBox();
            txtNoiDung = new TextBox();
            numSoLuongDuKien = new NumericUpDown();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            cboDiaDiem = new ComboBox();
            cboLoaiCongViec = new ComboBox();
            txtTieuDe = new TextBox();
            lblThongTinPhong = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
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
            MaLich = new DataGridViewTextBoxColumn();
            TieuDe = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            BatDau = new DataGridViewTextBoxColumn();
            KetThuc = new DataGridViewTextBoxColumn();
            SoLuongDuKien = new DataGridViewTextBoxColumn();
            MaLoaiCV = new DataGridViewTextBoxColumn();
            MaDiaDiem = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewLinkColumn();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongDuKien).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
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
            groupBox1.Size = new Size(1258, 402);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lịch làm việc";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(numSoLuongDuKien);
            panel2.Controls.Add(dtpKetThuc);
            panel2.Controls.Add(dtpBatDau);
            panel2.Controls.Add(cboDiaDiem);
            panel2.Controls.Add(cboLoaiCongViec);
            panel2.Controls.Add(txtTieuDe);
            panel2.Controls.Add(lblThongTinPhong);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnXuat);
            panel2.Controls.Add(btnNhap);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(128, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 348);
            panel2.TabIndex = 34;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(242, 242, 242);
            groupBox3.Controls.Add(txtNoiDung);
            groupBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox3.Location = new Point(5, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(701, 97);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = Color.FromArgb(242, 242, 242);
            txtNoiDung.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNoiDung.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtNoiDung.Location = new Point(1, 23);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(697, 74);
            txtNoiDung.TabIndex = 24;
            // 
            // numSoLuongDuKien
            // 
            numSoLuongDuKien.BackColor = Color.FromArgb(242, 242, 242);
            numSoLuongDuKien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            numSoLuongDuKien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            numSoLuongDuKien.Location = new Point(524, 223);
            numSoLuongDuKien.Name = "numSoLuongDuKien";
            numSoLuongDuKien.Size = new Size(179, 24);
            numSoLuongDuKien.TabIndex = 29;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.BackColor = Color.FromArgb(242, 242, 242);
            dtpKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpKetThuc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpKetThuc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.Location = new Point(524, 170);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(182, 24);
            dtpKetThuc.TabIndex = 28;
            // 
            // dtpBatDau
            // 
            dtpBatDau.BackColor = Color.FromArgb(242, 242, 242);
            dtpBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBatDau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpBatDau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(157, 170);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(183, 24);
            dtpBatDau.TabIndex = 27;
            // 
            // cboDiaDiem
            // 
            cboDiaDiem.BackColor = Color.FromArgb(242, 242, 242);
            cboDiaDiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboDiaDiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDiaDiem.FormattingEnabled = true;
            cboDiaDiem.Location = new Point(157, 274);
            cboDiaDiem.Name = "cboDiaDiem";
            cboDiaDiem.Size = new Size(545, 25);
            cboDiaDiem.TabIndex = 26;
            // 
            // cboLoaiCongViec
            // 
            cboLoaiCongViec.BackColor = Color.FromArgb(242, 242, 242);
            cboLoaiCongViec.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboLoaiCongViec.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLoaiCongViec.FormattingEnabled = true;
            cboLoaiCongViec.Location = new Point(157, 220);
            cboLoaiCongViec.Name = "cboLoaiCongViec";
            cboLoaiCongViec.Size = new Size(183, 25);
            cboLoaiCongViec.TabIndex = 25;
            // 
            // txtTieuDe
            // 
            txtTieuDe.BackColor = Color.FromArgb(242, 242, 242);
            txtTieuDe.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTieuDe.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtTieuDe.Location = new Point(101, 6);
            txtTieuDe.Multiline = true;
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(605, 30);
            txtTieuDe.TabIndex = 24;
            // 
            // lblThongTinPhong
            // 
            lblThongTinPhong.AutoSize = true;
            lblThongTinPhong.BackColor = Color.FromArgb(242, 242, 242);
            lblThongTinPhong.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblThongTinPhong.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblThongTinPhong.Location = new Point(6, 323);
            lblThongTinPhong.Name = "lblThongTinPhong";
            lblThongTinPhong.Size = new Size(230, 18);
            lblThongTinPhong.TabIndex = 22;
            lblThongTinPhong.Text = "Thông tin địa chỉ đang cập nhật...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 242, 242);
            label4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label4.Location = new Point(365, 226);
            label4.Name = "label4";
            label4.Size = new Size(134, 18);
            label4.TabIndex = 21;
            label4.Text = "Số lượng tham gia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 242, 242);
            label6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label6.Location = new Point(365, 170);
            label6.Name = "label6";
            label6.Size = new Size(132, 18);
            label6.TabIndex = 20;
            label6.Text = "Thời gian kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(242, 242, 242);
            label5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label5.Location = new Point(9, 223);
            label5.Name = "label5";
            label5.Size = new Size(109, 18);
            label5.TabIndex = 23;
            label5.Text = "Loại công việc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(242, 242, 242);
            label7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label7.Location = new Point(6, 283);
            label7.Name = "label7";
            label7.Size = new Size(72, 18);
            label7.TabIndex = 8;
            label7.Text = "Địa điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(5, 170);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 17;
            label3.Text = "Thời gian bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 16;
            label1.Text = "Tiêu đề (*):";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(242, 242, 242);
            btnXuat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXuat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXuat.Location = new Point(757, 261);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(246, 40);
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
            btnNhap.Location = new Point(757, 213);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(246, 40);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 242, 242);
            btnThoat.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThoat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThoat.Location = new Point(885, 93);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 40);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(885, 47);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 40);
            btnHuyBo.TabIndex = 12;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(242, 242, 242);
            btnTimKiem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTimKiem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnTimKiem.Location = new Point(757, 161);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(246, 40);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 242, 242);
            btnXoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnXoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnXoa.Location = new Point(757, 93);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 40);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(242, 242, 242);
            btnLuu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLuu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLuu.Location = new Point(885, 1);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 40);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(242, 242, 242);
            btnSua.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSua.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnSua.Location = new Point(757, 47);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 40);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(757, 1);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 40);
            btnThem.TabIndex = 19;
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
            groupBox2.Location = new Point(0, 402);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1258, 393);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lịch làm việc";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLich, TieuDe, NoiDung, BatDau, KetThuc, SoLuongDuKien, MaLoaiCV, MaDiaDiem, TinhTrang });
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
            dataGridView.Size = new Size(1252, 370);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.HeaderText = "Mã lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // TieuDe
            // 
            TieuDe.DataPropertyName = "TieuDe";
            TieuDe.HeaderText = "Tiêu đề";
            TieuDe.MinimumWidth = 6;
            TieuDe.Name = "TieuDe";
            TieuDe.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // BatDau
            // 
            BatDau.DataPropertyName = "ThoiGianBatDau";
            BatDau.HeaderText = "Thời gian bắt đầu";
            BatDau.MinimumWidth = 6;
            BatDau.Name = "BatDau";
            BatDau.ReadOnly = true;
            // 
            // KetThuc
            // 
            KetThuc.DataPropertyName = "ThoiGianKetThuc";
            KetThuc.HeaderText = "Thời gian kết thúc";
            KetThuc.MinimumWidth = 6;
            KetThuc.Name = "KetThuc";
            KetThuc.ReadOnly = true;
            // 
            // SoLuongDuKien
            // 
            SoLuongDuKien.DataPropertyName = "SoLuongDuKien";
            SoLuongDuKien.HeaderText = "Số lượng tham gia";
            SoLuongDuKien.MinimumWidth = 6;
            SoLuongDuKien.Name = "SoLuongDuKien";
            SoLuongDuKien.ReadOnly = true;
            // 
            // MaLoaiCV
            // 
            MaLoaiCV.DataPropertyName = "MaLoaiCV";
            MaLoaiCV.HeaderText = "Chức vụ";
            MaLoaiCV.MinimumWidth = 6;
            MaLoaiCV.Name = "MaLoaiCV";
            MaLoaiCV.ReadOnly = true;
            // 
            // MaDiaDiem
            // 
            MaDiaDiem.DataPropertyName = "MaDiaDiem";
            MaDiaDiem.HeaderText = "Địa điểm";
            MaDiaDiem.MinimumWidth = 6;
            MaDiaDiem.Name = "MaDiaDiem";
            MaDiaDiem.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            TinhTrang.Resizable = DataGridViewTriState.True;
            TinhTrang.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.BackColor = Color.FromArgb(242, 242, 242);
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            grBoxDanhSachLog.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grBoxDanhSachLog.Location = new Point(0, 637);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(1258, 158);
            grBoxDanhSachLog.TabIndex = 3;
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
            lstLog.Size = new Size(1252, 135);
            lstLog.TabIndex = 0;
            // 
            // frmLichLamViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 795);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLichLamViec";
            Text = "Lịch làm việc";
            WindowState = FormWindowState.Maximized;
            Load += frmLichLamViec_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongDuKien).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ListBox lstLog;
        private GroupBox grBoxDanhSachLog;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn TieuDe;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn BatDau;
        private DataGridViewTextBoxColumn KetThuc;
        private DataGridViewTextBoxColumn SoLuongDuKien;
        private DataGridViewTextBoxColumn MaLoaiCV;
        private DataGridViewTextBoxColumn MaDiaDiem;
        private DataGridViewLinkColumn TinhTrang;
        private Panel panel2;
        private GroupBox groupBox3;
        private NumericUpDown numSoLuongDuKien;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private ComboBox cboDiaDiem;
        private ComboBox cboLoaiCongViec;
        private TextBox txtTieuDe;
        private Label lblThongTinPhong;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label3;
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
        private TextBox txtNoiDung;
    }
}