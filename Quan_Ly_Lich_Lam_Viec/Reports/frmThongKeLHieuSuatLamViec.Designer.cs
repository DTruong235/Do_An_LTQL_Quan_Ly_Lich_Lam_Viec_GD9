namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    partial class frmThongKeLHieuSuatLamViec
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
            panel3 = new Panel();
            btnLamMoi = new Button();
            label2 = new Label();
            btnLoc = new Button();
            cboNhanVien = new ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.BackColor = Color.FromArgb(242, 242, 242);
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            reportViewer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            reportViewer.Location = new Point(0, 104);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(900, 414);
            reportViewer.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 104);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnLoc);
            panel3.Controls.Add(cboNhanVien);
            panel3.Location = new Point(132, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 43);
            panel3.TabIndex = 48;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(242, 242, 242);
            btnLamMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLamMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLamMoi.Location = new Point(512, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(92, 33);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(-3, 7);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 20;
            label2.Text = "Nhân viên:";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(242, 242, 242);
            btnLoc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLoc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLoc.Location = new Point(379, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(127, 33);
            btnLoc.TabIndex = 23;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(242, 242, 242);
            cboNhanVien.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboNhanVien.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(91, 4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(249, 25);
            cboNhanVien.TabIndex = 21;
            // 
            // frmThongKeLHieuSuatLamViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeLHieuSuatLamViec";
            Text = "Thống kê hiệu suất làm việc";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeLHieuSuatLamViec_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Panel panel3;
        private Button btnLamMoi;
        private Label label2;
        private Button btnLoc;
        private ComboBox cboNhanVien;
    }
}