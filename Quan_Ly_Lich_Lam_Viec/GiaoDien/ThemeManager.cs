using System.Text.Json;

namespace Quan_Ly_Lich_Lam_Viec.GiaoDien
{
    // Cấu trúc để lưu vào file JSON
    public class AppSettings
    {
        public bool IsDarkMode { get; set; } = false;
        public string PrimaryColorHex { get; set; } = "#1E90FF";
        public string BackgroundImagePath { get; set; } = "";
    }

    public static class ThemeManager
    {
        private static string configPath = "appsettings.json";
        public static AppSettings Config { get; set; } = new AppSettings();

        // Đọc cài đặt khi mở App
        public static void LoadConfig()
        {
            if (File.Exists(configPath))
            {
                try
                {
                    string json = File.ReadAllText(configPath);
                    Config = JsonSerializer.Deserialize<AppSettings>(json);
                }
                catch { /* Bỏ qua nếu file lỗi, xài mặc định */ }
            }
        }

        //Lưu cài đặt khi người dùng bấm Lưu
        public static void SaveConfig()
        {
            string json = JsonSerializer.Serialize(Config);
            File.WriteAllText(configPath, json);
        }

        // Hàm áp dụng cho các Form con (áp dụng vào frmBase)
        public static void ApplyTheme(Form frm)
        {
            Color backColor = Config.IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
            Color textColor = Config.IsDarkMode ? Color.White : Color.Black;
            Color primaryColor = ColorTranslator.FromHtml(Config.PrimaryColorHex);

            frm.BackColor = backColor;
            frm.ForeColor = textColor;

            // Đổi màu mấy cái lưới (DataGridView) cho tiệp với Dark Mode
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = backColor;
                    dgv.DefaultCellStyle.BackColor = backColor;
                    dgv.DefaultCellStyle.ForeColor = textColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false; // Bắt buộc false mới đổi màu Header được
                }
            }
        }
    }
}
