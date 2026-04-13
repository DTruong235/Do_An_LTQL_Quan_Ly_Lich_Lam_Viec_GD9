using Quan_Ly_Lich_Lam_Viec.Forms;

namespace Quan_Ly_Lich_Lam_Viec.GiaoDien
{
    public partial class frmCaiDat : frmBase
    {
        private string mauMoi = "";

        public frmCaiDat()
        {
            InitializeComponent();
        }

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            // Load trạng thái hiện tại lên giao diện
            chkDarkMode.Checked = ThemeManager.Config.IsDarkMode;
            mauMoi = ThemeManager.Config.PrimaryColorHex;

            btnChonMau.FlatAppearance.BorderColor = ColorTranslator.FromHtml(mauMoi);
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                mauMoi = ColorTranslator.ToHtml(cd.Color);
                btnChonMau.ForeColor = cd.Color;
                btnChonMau.FlatAppearance.BorderColor = cd.Color;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cập nhật vào Config
            ThemeManager.Config.IsDarkMode = chkDarkMode.Checked;
            ThemeManager.Config.PrimaryColorHex = mauMoi;

            //Lưu xuống ổ cứng
            ThemeManager.SaveConfig();

            DialogResult result = MessageBox.Show(
            "Đã lưu cấu hình thành công! Bạn có muốn khởi động lại ứng dụng ngay bây giờ để áp dụng giao diện mới không?",
            "Khởi động lại hệ thống",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Bấm Yes -> Tự động tắt app hiện tại và mở lên lại
                Application.Restart();
            }
            else
            {
                // Bấm No -> Chỉ đóng cái form cài đặt này thôi, làm việc tiếp
                this.Close();
            }
        }

        private void btnCaiDatLai_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show(
        "Bạn có chắc chắn muốn xóa toàn bộ cài đặt màu sắc và khôi phục giao diện về mặc định ban đầu không?",
        "Xác nhận khôi phục",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (xacNhan == DialogResult.Yes)
            {
                // KHỞI TẠO LẠI BỘ NHỚ LÕI (Xóa sạch dữ liệu cũ)
                // Lệnh new AppSettings() sẽ trả mọi thứ về: DarkMode=false, Màu=Xanh
                ThemeManager.Config = new AppSettings();

                // Ghi đè file JSON mới tinh xuống ổ cứng (xóa sổ file cũ)
                ThemeManager.SaveConfig();

                // Cập nhật lại giao diện Form Cài đặt ngay lập tức cho user thấy
                chkDarkMode.Checked = false;
                mauMoi = ThemeManager.Config.PrimaryColorHex;
                btnChonMau.BackColor = ColorTranslator.FromHtml(mauMoi);
                btnChonMau.ForeColor = Color.White;

                // 5. Hỏi khởi động lại để áp dụng
                DialogResult result = MessageBox.Show(
                    "Đã khôi phục dữ liệu gốc thành công! Bạn có muốn khởi động lại ứng dụng để dọn dẹp giao diện ngay bây giờ không?",
                    "Khởi động lại hệ thống",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }
    }
}

