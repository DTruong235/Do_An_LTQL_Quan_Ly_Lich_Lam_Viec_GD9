using Quan_Ly_Lich_Lam_Viec.Data;
using BC = BCrypt.Net.BCrypt;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmDoiMatKhau : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            lblDoiMatKhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) || string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // 2. Kiểm tra khớp mật khẩu mới
            if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp!", "Lỗi");
                return;
            }

            try
            {
                // 3. Lấy tài khoản đang đăng nhập từ Program.cs
                var uName = Program.CurrentUser.Username;
                var tkInDb = context.Tai_Khoan.SingleOrDefault(t => t.Username == uName);

                // 4. Kiểm tra mật khẩu cũ có đúng không
                if (BC.Verify(txtMatKhauCu.Text, tkInDb.Password))
                {
                    // 5. Mã hóa mật khẩu mới và lưu
                    tkInDb.Password = BC.HashPassword(txtMatKhauMoi.Text);
                    context.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công");
                    DataHelper.WriteLog("Đổi mật khẩu", $"Người dùng {uName} đã đổi mật khẩu thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
