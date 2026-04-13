namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDoiMatKhau
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
            btnHuyBo = new Button();
            btnDoiMatKhau = new Button();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblDoiMatKhau = new Label();
            label4 = new Label();
            txtXacNhanMatKhau = new TextBox();
            SuspendLayout();
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(242, 242, 242);
            btnHuyBo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnHuyBo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnHuyBo.Location = new Point(194, 314);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 33);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(242, 242, 242);
            btnDoiMatKhau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnDoiMatKhau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnDoiMatKhau.Location = new Point(48, 314);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(124, 33);
            btnDoiMatKhau.TabIndex = 9;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BackColor = Color.FromArgb(242, 242, 242);
            txtMatKhauMoi.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatKhauMoi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtMatKhauMoi.Location = new Point(48, 186);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(264, 24);
            txtMatKhauMoi.TabIndex = 6;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BackColor = Color.FromArgb(242, 242, 242);
            txtMatKhauCu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatKhauCu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtMatKhauCu.Location = new Point(48, 110);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(264, 24);
            txtMatKhauCu.TabIndex = 0;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(48, 160);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(48, 84);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu cũ:";
            // 
            // lblDoiMatKhau
            // 
            lblDoiMatKhau.AutoSize = true;
            lblDoiMatKhau.BackColor = Color.White;
            lblDoiMatKhau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDoiMatKhau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDoiMatKhau.Location = new Point(61, 31);
            lblDoiMatKhau.Name = "lblDoiMatKhau";
            lblDoiMatKhau.Size = new Size(111, 18);
            lblDoiMatKhau.TabIndex = 10;
            lblDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label4.Location = new Point(48, 235);
            label4.Name = "label4";
            label4.Size = new Size(169, 18);
            label4.TabIndex = 4;
            label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.BackColor = Color.FromArgb(242, 242, 242);
            txtXacNhanMatKhau.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtXacNhanMatKhau.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtXacNhanMatKhau.Location = new Point(48, 261);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(264, 24);
            txtXacNhanMatKhau.TabIndex = 6;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 371);
            Controls.Add(lblDoiMatKhau);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label4);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuyBo;
        private Button btnDoiMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtMatKhauCu;
        private Label label3;
        private Label label2;
        private Label lblDoiMatKhau;
        private Label label4;
        private TextBox txtXacNhanMatKhau;
    }
}