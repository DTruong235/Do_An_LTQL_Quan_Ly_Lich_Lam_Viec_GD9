namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    partial class frmThongKeChiTietCongViec
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLamMoi = new Button();
            cboTenLich = new ComboBox();
            btnLoc = new Button();
            label1 = new Label();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.BackColor = Color.FromArgb(242, 242, 242);
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            reportViewer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            reportViewer.Location = new Point(0, 120);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1151, 398);
            reportViewer.TabIndex = 1;
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
            panel1.Size = new Size(1151, 120);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(cboTenLich);
            panel2.Controls.Add(btnLoc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboNhanVien);
            panel2.Location = new Point(12, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 54);
            panel2.TabIndex = 46;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(242, 242, 242);
            btnLamMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLamMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLamMoi.Location = new Point(922, 7);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(131, 33);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboTenLich
            // 
            cboTenLich.BackColor = Color.FromArgb(242, 242, 242);
            cboTenLich.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboTenLich.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTenLich.FormattingEnabled = true;
            cboTenLich.Location = new Point(435, 8);
            cboTenLich.Name = "cboTenLich";
            cboTenLich.Size = new Size(318, 25);
            cboTenLich.TabIndex = 14;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(242, 242, 242);
            btnLoc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLoc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLoc.Location = new Point(785, 7);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(131, 33);
            btnLoc.TabIndex = 17;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(0, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 13;
            label1.Text = "Nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(351, 11);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 12;
            label2.Text = "Tên lịch:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(242, 242, 242);
            cboNhanVien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboNhanVien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(95, 7);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(230, 25);
            cboNhanVien.TabIndex = 15;
            // 
            // frmThongKeChiTietCongViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 518);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeChiTietCongViec";
            StartPosition = FormStartPosition.Manual;
            Text = "Thống kê chi tiết công việc";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeChiTietCongViec_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Panel panel2;
        private Button btnLamMoi;
        private ComboBox cboTenLich;
        private Button btnLoc;
        private Label label1;
        private Label label2;
        private ComboBox cboNhanVien;
    }
}