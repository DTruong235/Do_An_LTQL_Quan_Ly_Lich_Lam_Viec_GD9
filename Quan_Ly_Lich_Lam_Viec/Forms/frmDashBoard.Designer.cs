namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            lblXinChao = new Label();
            lblNgayThang = new Label();
            pnlCard3 = new Panel();
            pnlSubCard3 = new Panel();
            lblSoCard3 = new Label();
            lblTieuDeCard3 = new Label();
            pnlCard1 = new Panel();
            pnlSubCard1 = new Panel();
            lblSoCard1 = new Label();
            lblTieuDeCard1 = new Label();
            panel6 = new Panel();
            pnlCard2 = new Panel();
            pnlSubCard2 = new Panel();
            lblSoCard2 = new Label();
            lblTieuDeCard2 = new Label();
            panel2 = new Panel();
            chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            dataGridView = new DataGridView();
            TieuDe = new DataGridViewTextBoxColumn();
            BatDau = new DataGridViewTextBoxColumn();
            KetThuc = new DataGridViewTextBoxColumn();
            MaDiaDiem = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel7 = new Panel();
            btnThem = new Button();
            lblTieuDeGrid = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlSubCard3.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlSubCard1.SuspendLayout();
            panel6.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlSubCard2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartThongKe).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1942, 156);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(lblXinChao);
            panel4.Controls.Add(lblNgayThang);
            panel4.Location = new Point(468, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(1095, 104);
            panel4.TabIndex = 2;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Location = new Point(354, 0);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(55, 23);
            lblXinChao.TabIndex = 0;
            lblXinChao.Text = "label1";
            // 
            // lblNgayThang
            // 
            lblNgayThang.AutoSize = true;
            lblNgayThang.Location = new Point(414, 63);
            lblNgayThang.Name = "lblNgayThang";
            lblNgayThang.Size = new Size(55, 23);
            lblNgayThang.TabIndex = 1;
            lblNgayThang.Text = "label2";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.LimeGreen;
            pnlCard3.Controls.Add(pnlSubCard3);
            pnlCard3.Dock = DockStyle.Right;
            pnlCard3.Location = new Point(1398, 0);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(544, 148);
            pnlCard3.TabIndex = 1;
            pnlCard3.Click += pnlCard3_Click;
            // 
            // pnlSubCard3
            // 
            pnlSubCard3.Anchor = AnchorStyles.None;
            pnlSubCard3.Controls.Add(lblSoCard3);
            pnlSubCard3.Controls.Add(lblTieuDeCard3);
            pnlSubCard3.Location = new Point(186, 17);
            pnlSubCard3.Name = "pnlSubCard3";
            pnlSubCard3.Size = new Size(183, 101);
            pnlSubCard3.TabIndex = 5;
            // 
            // lblSoCard3
            // 
            lblSoCard3.AutoSize = true;
            lblSoCard3.Location = new Point(81, 62);
            lblSoCard3.Name = "lblSoCard3";
            lblSoCard3.Size = new Size(19, 23);
            lblSoCard3.TabIndex = 1;
            lblSoCard3.Text = "0";
            // 
            // lblTieuDeCard3
            // 
            lblTieuDeCard3.AutoSize = true;
            lblTieuDeCard3.Location = new Point(29, 14);
            lblTieuDeCard3.Name = "lblTieuDeCard3";
            lblTieuDeCard3.Size = new Size(125, 23);
            lblTieuDeCard3.TabIndex = 2;
            lblTieuDeCard3.Text = "Đã hoàn thành";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.DeepSkyBlue;
            pnlCard1.Controls.Add(pnlSubCard1);
            pnlCard1.Dock = DockStyle.Left;
            pnlCard1.Location = new Point(0, 0);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(590, 148);
            pnlCard1.TabIndex = 2;
            pnlCard1.Click += pnlCard1_Click;
            // 
            // pnlSubCard1
            // 
            pnlSubCard1.Anchor = AnchorStyles.None;
            pnlSubCard1.Controls.Add(lblSoCard1);
            pnlSubCard1.Controls.Add(lblTieuDeCard1);
            pnlSubCard1.Location = new Point(206, 17);
            pnlSubCard1.Name = "pnlSubCard1";
            pnlSubCard1.Size = new Size(222, 101);
            pnlSubCard1.TabIndex = 3;
            // 
            // lblSoCard1
            // 
            lblSoCard1.AutoSize = true;
            lblSoCard1.Location = new Point(75, 62);
            lblSoCard1.Name = "lblSoCard1";
            lblSoCard1.Size = new Size(19, 23);
            lblSoCard1.TabIndex = 0;
            lblSoCard1.Text = "0";
            // 
            // lblTieuDeCard1
            // 
            lblTieuDeCard1.AutoSize = true;
            lblTieuDeCard1.Location = new Point(15, 13);
            lblTieuDeCard1.Name = "lblTieuDeCard1";
            lblTieuDeCard1.Size = new Size(152, 23);
            lblTieuDeCard1.TabIndex = 0;
            lblTieuDeCard1.Text = "Tổng lịch hôm nay";
            // 
            // panel6
            // 
            panel6.Controls.Add(pnlCard2);
            panel6.Controls.Add(pnlCard1);
            panel6.Controls.Add(pnlCard3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(1942, 148);
            panel6.TabIndex = 3;
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.SandyBrown;
            pnlCard2.Controls.Add(pnlSubCard2);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.Location = new Point(590, 0);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(808, 148);
            pnlCard2.TabIndex = 4;
            pnlCard2.Click += pnlCard2_Click;
            // 
            // pnlSubCard2
            // 
            pnlSubCard2.Anchor = AnchorStyles.None;
            pnlSubCard2.Controls.Add(lblSoCard2);
            pnlSubCard2.Controls.Add(lblTieuDeCard2);
            pnlSubCard2.Location = new Point(310, 17);
            pnlSubCard2.Name = "pnlSubCard2";
            pnlSubCard2.Size = new Size(183, 101);
            pnlSubCard2.TabIndex = 4;
            // 
            // lblSoCard2
            // 
            lblSoCard2.AutoSize = true;
            lblSoCard2.Location = new Point(79, 62);
            lblSoCard2.Name = "lblSoCard2";
            lblSoCard2.Size = new Size(19, 23);
            lblSoCard2.TabIndex = 0;
            lblSoCard2.Text = "0";
            // 
            // lblTieuDeCard2
            // 
            lblTieuDeCard2.AutoSize = true;
            lblTieuDeCard2.Location = new Point(43, 13);
            lblTieuDeCard2.Name = "lblTieuDeCard2";
            lblTieuDeCard2.Size = new Size(106, 23);
            lblTieuDeCard2.TabIndex = 0;
            lblTieuDeCard2.Text = "Sắp đến hạn";
            // 
            // panel2
            // 
            panel2.Controls.Add(chartThongKe);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 199);
            panel2.TabIndex = 4;
            // 
            // chartThongKe
            // 
            chartArea2.Name = "ChartArea1";
            chartThongKe.ChartAreas.Add(chartArea2);
            chartThongKe.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartThongKe.Legends.Add(legend2);
            chartThongKe.Location = new Point(0, 0);
            chartThongKe.Name = "chartThongKe";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartThongKe.Series.Add(series2);
            chartThongKe.Size = new Size(664, 199);
            chartThongKe.TabIndex = 0;
            chartThongKe.Text = "chart1";
            chartThongKe.Click += chartThongKe_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(664, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(1278, 199);
            panel3.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TieuDe, BatDau, KetThuc, MaDiaDiem, TinhTrang });
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
            dataGridView.Location = new Point(0, 64);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1278, 135);
            dataGridView.TabIndex = 7;
            dataGridView.DoubleClick += dataGridView_DoubleClick;
            // 
            // TieuDe
            // 
            TieuDe.DataPropertyName = "TieuDe";
            TieuDe.HeaderText = "Tiêu đề";
            TieuDe.MinimumWidth = 6;
            TieuDe.Name = "TieuDe";
            TieuDe.ReadOnly = true;
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
            TinhTrang.DataPropertyName = "PhanTramHoanThanh";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1278, 64);
            panel5.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(btnThem);
            panel7.Controls.Add(lblTieuDeGrid);
            panel7.Location = new Point(513, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(710, 52);
            panel7.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(242, 242, 242);
            btnThem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnThem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnThem.Location = new Point(572, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 40);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm lịch mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTieuDeGrid
            // 
            lblTieuDeGrid.AutoSize = true;
            lblTieuDeGrid.Location = new Point(3, 10);
            lblTieuDeGrid.Name = "lblTieuDeGrid";
            lblTieuDeGrid.Size = new Size(147, 23);
            lblTieuDeGrid.TabIndex = 0;
            lblTieuDeGrid.Text = "DANH SÁCH LỊCH";
            lblTieuDeGrid.Click += lblTieuDeGrid_Click;
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1942, 503);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashBoard";
            Text = "frmDashBoard";
            WindowState = FormWindowState.Maximized;
            Load += frmDashBoard_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlSubCard3.ResumeLayout(false);
            pnlSubCard3.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlSubCard1.ResumeLayout(false);
            pnlSubCard1.PerformLayout();
            panel6.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlSubCard2.ResumeLayout(false);
            pnlSubCard2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartThongKe).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNgayThang;
        private Label lblXinChao;
        private Panel pnlCard3;
        private Panel panel4;
        private Panel pnlCard1;
        private Panel panel6;
        private Panel pnlCard2;
        private Label lblTieuDeCard1;
        private Label lblSoCard1;
        private Label lblSoCard2;
        private Label lblTieuDeCard2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label lblTieuDeGrid;
        private DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private Panel panel7;
        private Panel pnlSubCard3;
        private Label lblSoCard3;
        private Label lblTieuDeCard3;
        private Panel pnlSubCard1;
        private Panel pnlSubCard2;
        private DataGridViewTextBoxColumn TieuDe;
        private DataGridViewTextBoxColumn BatDau;
        private DataGridViewTextBoxColumn KetThuc;
        private DataGridViewTextBoxColumn MaDiaDiem;
        private DataGridViewTextBoxColumn TinhTrang;
        private Button btnThem;
    }
}