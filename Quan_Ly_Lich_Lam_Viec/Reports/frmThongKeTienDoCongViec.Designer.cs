namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    partial class frmThongKeTienDoCongViec
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnLamMoi = new Button();
            label2 = new Label();
            cboTenLich = new ComboBox();
            btnLoc = new Button();
            panel2 = new Panel();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(900, 116);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cboTenLich);
            panel3.Controls.Add(btnLoc);
            panel3.Location = new Point(68, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(761, 48);
            panel3.TabIndex = 52;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(242, 242, 242);
            btnLamMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLamMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLamMoi.Location = new Point(653, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 33);
            btnLamMoi.TabIndex = 18;
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
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 16;
            label2.Text = "Tên lịch:";
            // 
            // cboTenLich
            // 
            cboTenLich.BackColor = Color.FromArgb(242, 242, 242);
            cboTenLich.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboTenLich.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTenLich.FormattingEnabled = true;
            cboTenLich.Location = new Point(83, 3);
            cboTenLich.Name = "cboTenLich";
            cboTenLich.Size = new Size(384, 25);
            cboTenLich.TabIndex = 17;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(242, 242, 242);
            btnLoc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLoc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLoc.Location = new Point(498, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(149, 33);
            btnLoc.TabIndex = 16;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 242);
            panel2.Controls.Add(reportViewer);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(0, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 402);
            panel2.TabIndex = 1;
            // 
            // reportViewer
            // 
            reportViewer.BackColor = Color.FromArgb(242, 242, 242);
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            reportViewer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            reportViewer.Location = new Point(0, 0);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(900, 402);
            reportViewer.TabIndex = 0;
            // 
            // frmThongKeTienDoCongViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmThongKeTienDoCongViec";
            Text = "Thống kê tiến độ công việc";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeTienDoCongViec_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel3;
        private Button btnLamMoi;
        private Label label2;
        private ComboBox cboTenLich;
        private Button btnLoc;
    }
}