namespace Quan_Ly_Lich_Lam_Viec.GiaoDien
{
    partial class frmCaiDat
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
            chkDarkMode = new CheckBox();
            btnChonMau = new Button();
            btnLuu = new Button();
            btnCaiDatLai = new Button();
            SuspendLayout();
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(63, 49);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(112, 27);
            chkDarkMode.TabIndex = 0;
            chkDarkMode.Text = "Chế độ tối";
            chkDarkMode.UseVisualStyleBackColor = true;
            // 
            // btnChonMau
            // 
            btnChonMau.Location = new Point(63, 110);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(165, 33);
            btnChonMau.TabIndex = 1;
            btnChonMau.Text = "Đổi màu chủ đề...";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += btnChonMau_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(63, 217);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(165, 33);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu...";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCaiDatLai
            // 
            btnCaiDatLai.Location = new Point(63, 162);
            btnCaiDatLai.Name = "btnCaiDatLai";
            btnCaiDatLai.Size = new Size(165, 33);
            btnCaiDatLai.TabIndex = 1;
            btnCaiDatLai.Text = "Cài đặt lại";
            btnCaiDatLai.UseVisualStyleBackColor = true;
            btnCaiDatLai.Click += btnCaiDatLai_Click;
            // 
            // frmCaiDat
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(289, 289);
            Controls.Add(btnLuu);
            Controls.Add(btnCaiDatLai);
            Controls.Add(btnChonMau);
            Controls.Add(chkDarkMode);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCaiDat";
            Text = "Cấu hình";
            Load += frmCaiDat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkDarkMode;
        private Button btnChonMau;
        private Button btnLuu;
        private Button btnCaiDatLai;
    }
}