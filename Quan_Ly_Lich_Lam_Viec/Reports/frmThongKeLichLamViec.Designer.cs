namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    partial class frmThongKeLichLamViec
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
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            btnLamMoi = new Button();
            btnLoc = new Button();
            label2 = new Label();
            label1 = new Label();
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
            reportViewer.Location = new Point(0, 100);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(900, 418);
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
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(dtpKetThuc);
            panel2.Controls.Add(dtpBatDau);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnLoc);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(108, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 39);
            panel2.TabIndex = 50;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.BackColor = Color.FromArgb(242, 242, 242);
            dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpKetThuc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpKetThuc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.Location = new Point(341, 8);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(137, 24);
            dtpKetThuc.TabIndex = 11;
            // 
            // dtpBatDau
            // 
            dtpBatDau.BackColor = Color.FromArgb(242, 242, 242);
            dtpBatDau.CustomFormat = "dd/MM/yyyy";
            dtpBatDau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpBatDau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(82, 8);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(137, 24);
            dtpBatDau.TabIndex = 12;
            dtpBatDau.ValueChanged += dtpBatDau_ValueChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(242, 242, 242);
            btnLamMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLamMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLamMoi.Location = new Point(644, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(92, 33);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(242, 242, 242);
            btnLoc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLoc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnLoc.Location = new Point(507, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(131, 33);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(242, 14);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 7;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(0, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 8;
            label1.Text = "Từ ngày:";
            // 
            // frmThongKeLichLamViec
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeLichLamViec";
            Text = "Thống kê lịch làm việc";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeLichLamViec_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Button btnLamMoi;
        private Button btnLoc;
        private Label label2;
        private Label label1;
    }
}