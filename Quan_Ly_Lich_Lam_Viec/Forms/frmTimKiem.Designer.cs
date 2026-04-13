namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmTimKiem
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
            label1 = new Label();
            txtTuKhoa = new TextBox();
            btnXacNhan = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập nội dung cần tìm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(49, 76);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(305, 30);
            txtTuKhoa.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(69, 131);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(106, 33);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(212, 131);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(106, 33);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmTimKiem
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 194);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTimKiem";
            StartPosition = FormStartPosition.Manual;
            Text = "Tìm kiếm";
            Load += frmTimKiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}