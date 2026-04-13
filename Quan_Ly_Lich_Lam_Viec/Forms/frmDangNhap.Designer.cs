namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDangNhap
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
            pictureBox1 = new PictureBox();
            lblDangNhap = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Enabled = false;
            pictureBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox1.Image = Properties.Resources.DangNhap1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.BackColor = Color.FromArgb(242, 242, 242);
            lblDangNhap.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDangNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDangNhap.Location = new Point(57, 21);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(161, 32);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.FromArgb(242, 242, 242);
            txtTenDangNhap.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTenDangNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtTenDangNhap.Location = new Point(28, 101);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(264, 24);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(242, 242, 242);
            txtMatKhau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatKhau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtMatKhau.Location = new Point(28, 173);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(264, 24);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(242, 242, 242);
            btnDangNhap.Font = new Font("Segoe UI", 9F);
            btnDangNhap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnDangNhap.Location = new Point(28, 229);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(124, 33);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Segoe UI", 9F);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(173, 229);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 33);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(lblDangNhap);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(321, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 288);
            panel1.TabIndex = 4;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(643, 288);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            ShowInTaskbar = false;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDangNhap;
        private Label label2;
        private Label label3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private Panel panel1;
    }
}
