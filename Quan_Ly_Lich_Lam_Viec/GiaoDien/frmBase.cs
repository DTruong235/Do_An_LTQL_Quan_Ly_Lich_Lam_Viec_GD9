using Quan_Ly_Lich_Lam_Viec.GiaoDien;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{

    public partial class frmBase : Form
    {

        public HelpProvider hpToanCuc;

        public frmBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false; // Tắt icon mặc định cho phẳng

            hpToanCuc = new HelpProvider();

            hpToanCuc.HelpNamespace = "ĐƯỜNG_DẪN_TRANG_WEB_CỦA_BẠN_TRÊN_GITHUB";
        }

        // Đổi thành các biến động, sẽ được gán giá trị từ JSON
        public Color PrimaryColor;
        public Color BackColorTheme;
        public Color TextColorTheme;

        public void SetupGiaoDien(Control parent)
        {
            // CẤU HÌNH THEME TỪ MÀN HÌNH CHÍNH (Chỉ chạy 1 lần khi parent là Form)

            if (parent is Form frm)
            {
                // Gọi hàm LoadConfig để đảm bảo luôn lấy setting mới nhất
                ThemeManager.LoadConfig();

                // Setup màu sắc sáng/tối
                BackColorTheme = ThemeManager.Config.IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
                TextColorTheme = ThemeManager.Config.IsDarkMode ? Color.White : Color.Black;

                // Tránh lỗi nếu JSON chưa có màu (trống) thì lấy mặc định là màu Xanh
                try { PrimaryColor = ColorTranslator.FromHtml(ThemeManager.Config.PrimaryColorHex); }
                catch { PrimaryColor = Color.FromArgb(33, 150, 243); }

                // Áp dụng nền và chữ cho Form
                frm.BackColor = BackColorTheme;
                frm.ForeColor = TextColorTheme;
                frm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
            }

            // BƯỚC 2: QUÉT ĐỆ QUY CÁC CONTROL

            foreach (Control ctrl in parent.Controls)
            {
                Font font = new Font("Segoe UI", 11F, FontStyle.Regular);

                // -- XỬ LÝ NÚT BẤM (BUTTON) --
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                    btn.BackColor = BackColorTheme;
                    btn.FlatAppearance.BorderSize = 1;

                    string name = btn.Name.ToLower();

                    // NHÓM 1: CÁC NÚT ĐẶC BIỆT ĐÃ THIẾT LẬP SẴN MÀU
                    if (name.Contains("xoa"))
                    {
                        btn.ForeColor = Color.Crimson;
                        btn.FlatAppearance.BorderColor = Color.Crimson;
                    }
                    else if (name.Contains("thoat"))
                    {
                        btn.ForeColor = Color.Red;
                        btn.FlatAppearance.BorderColor = Color.Red;
                    }
                    else if (name.Contains("them") || name.Contains("luu"))
                    {
                        btn.ForeColor = Color.SeaGreen;
                        btn.FlatAppearance.BorderColor = Color.SeaGreen;
                    }
                    else if (name.Contains("sua"))
                    {
                        btn.ForeColor = Color.DarkOrange;
                        btn.FlatAppearance.BorderColor = Color.DarkOrange;
                    }
                    else if (name.Contains("huy"))
                    {
                        btn.ForeColor = Color.DarkCyan;
                        btn.FlatAppearance.BorderColor = Color.DarkCyan;
                    }
                    // NHÓM 2: CÁC NÚT CÒN LẠI (TÌM KIẾM, NHẬP, XUẤT...)
                    else
                    {
                        btn.ForeColor = PrimaryColor;
                        btn.FlatAppearance.BorderColor = PrimaryColor;
                    }

                    btn.FlatAppearance.MouseOverBackColor = btn.FlatAppearance.BorderColor;
                    btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.BorderColor;

                    // Bắt sự kiện: Chuột đi VÀO nút
                    btn.MouseEnter += (s, ev) =>
                    {
                        btn.ForeColor = Color.White; // Chữ auto chuyển sang Trắng cho nổi bật
                    };

                    // Bắt sự kiện: Chuột đi RA KHỎI nút
                    btn.MouseLeave += (s, ev) =>
                    {
                        // Trả lại nền Dark/Light mode và trả lại màu chữ ban đầu
                        btn.BackColor = BackColorTheme;
                        btn.ForeColor = btn.FlatAppearance.BorderColor;
                    };
                }



                // -- XỬ LÝ Ô NHẬP LIỆU (TEXTBOX / COMBOBOX) --
                else if (ctrl is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = BackColorTheme;
                    txt.ForeColor = TextColorTheme; // Đổi màu chữ gõ vào
                    txt.Font = font;
                }

                else if (ctrl is ComboBox cbo)
                {
                    cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbo.FlatStyle = FlatStyle.Flat;
                    cbo.BackColor = BackColorTheme;
                    cbo.ForeColor = TextColorTheme;
                    cbo.Font = font;
                }

                // -- XỬ LÝ DATAGRIDVIEW (BẢNG DỮ LIỆU) --
                else if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = BackColorTheme;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    // Tiêu đề bảng lấy theo Màu Chủ Đề
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
                    dgv.EnableHeadersVisualStyles = false;

                    dgv.RowHeadersVisible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Phối màu dòng chẵn lẻ cho phù hợp Dark Mode/Light Mode
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = ThemeManager.Config.IsDarkMode ? Color.FromArgb(40, 40, 40) : Color.FromArgb(245, 245, 245);

                    // Màu chữ trong bảng
                    dgv.DefaultCellStyle.ForeColor = TextColorTheme;
                    dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextColorTheme;
                    dgv.DefaultCellStyle.BackColor = BackColorTheme;

                    dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
                    dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gray;
                }

                // -- XỬ LÝ CHECKEDLISTBOX (DANH SÁCH ĐÁNH DẤU) --
                else if (ctrl is CheckedListBox clb)
                {
                    clb.BackColor = BackColorTheme;
                    clb.ForeColor = TextColorTheme;
                    clb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);

                    clb.BorderStyle = BorderStyle.FixedSingle;
                }


                // -- XỬ LÝ GROUPBOX --
                else if (ctrl is GroupBox gb)
                {
                    gb.ForeColor = TextColorTheme;
                    gb.BackColor = BackColorTheme;
                    gb.ForeColor = TextColorTheme;
                    gb.Font = new Font("Segoe UI", 10.2F);
                }

                // -- XỬ LÝ NHÃN (LABEL), CHECKBOX, RADIO --
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = TextColorTheme;
                    lbl.BackColor = Color.Transparent;
                    lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                }
                else if (ctrl is CheckBox chk)
                {
                    chk.ForeColor = TextColorTheme;
                    chk.BackColor = Color.Transparent;
                    chk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                }
                else if (ctrl is RadioButton rdo)
                {
                    rdo.ForeColor = TextColorTheme;
                    rdo.BackColor = Color.Transparent;
                    rdo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                }
                else if (ctrl is NumericUpDown nud)
                {
                    nud.BackColor = BackColorTheme;
                    nud.ForeColor = TextColorTheme;
                    nud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    dtp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                }

                // -- XỬ LÝ PANEL --
                else if (ctrl is Panel pnl)
                {
                    // Bỏ qua không đổi màu mấy cái Thẻ (Card) trên Dashboard
                    if (!pnl.Name.ToLower().Contains("card"))
                    {
                        pnl.BackColor = BackColorTheme;
                        pnl.ForeColor = TextColorTheme;
                    }
                }

                // -- XỬ LÝ PICTUREBOX (HÌNH ẢNH) --
                else if (ctrl is PictureBox pic)
                {
                    // Rất hữu ích khi hình ảnh của bạn là PNG nền trong suốt (logo, icon)
                    pic.BackColor = BackColorTheme;
                }

                // -- XỬ LÝ BIỂU ĐỒ (CHART) --
                else if (ctrl is Chart chart)
                {
                    // Nền tổng thể của biểu đồ
                    chart.BackColor = BackColorTheme;
                    chart.ForeColor = TextColorTheme;

                    // Đổi màu chữ Tiêu đề (Nếu bạn có thêm Title)
                    foreach (Title title in chart.Titles)
                    {
                        title.ForeColor = PrimaryColor;
                    }

                    // Đổi màu Chú giải (Legend)
                    foreach (Legend legend in chart.Legends)
                    {
                        legend.BackColor = Color.Transparent; // Xóa nền trắng của chú giải
                        legend.ForeColor = TextColorTheme;    // Chữ chú giải đổi sang Trắng/Đen
                    }

                    // Đổi màu Khu vực vẽ lưới cột
                    foreach (ChartArea area in chart.ChartAreas)
                    {
                        area.BackColor = Color.Transparent; // Xóa nền trắng khu vực vẽ

                        // -- Xử lý Trục X (Trục ngang) --
                        area.AxisX.LabelStyle.ForeColor = TextColorTheme; // Màu chữ (Hôm nay, Sắp trễ...)
                        area.AxisX.LineColor = ThemeManager.Config.IsDarkMode ? Color.Gray : Color.Black;

                        // Lưới dọc (Thường tắt, nhưng nếu bật thì cho màu chìm xuống)
                        area.AxisX.MajorGrid.LineColor = ThemeManager.Config.IsDarkMode ? Color.FromArgb(60, 60, 60) : Color.LightGray;

                        // -- Xử lý Trục Y (Trục dọc) --
                        area.AxisY.LabelStyle.ForeColor = TextColorTheme; // Màu số (0, 1, 2, 3...)
                        area.AxisY.LineColor = ThemeManager.Config.IsDarkMode ? Color.Gray : Color.Black;

                        // Lưới ngang 
                        area.AxisY.MajorGrid.LineColor = ThemeManager.Config.IsDarkMode ? Color.FromArgb(60, 60, 60) : Color.LightGray;
                    }

                }

                // GỌI ĐỆ QUY
                if (ctrl.HasChildren)
                {
                    SetupGiaoDien(ctrl);
                }
            }
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
        }


        public bool LocDuLieuLINQ<T>(BindingSource bs, List<T> danhSachGoc, string tuKhoa)
        {
            // Nếu danh sách rỗng thì không làm gì cả
            if (danhSachGoc == null || danhSachGoc.Count == 0) return false;

            try
            {
                // Nếu từ khóa rỗng -> Trả về true để Form con tự reset lại danh sách
                if (string.IsNullOrEmpty(tuKhoa)) return true;

                string keyword = tuKhoa.ToLower();

                // Dùng LINQ lùng sục tất cả các cột
                var ketQua = danhSachGoc.Where(item =>
                {
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        // Bỏ qua các class liên kết (như Phong_Ban, Chuc_Vu)
                        if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                            continue;

                        var val = prop.GetValue(item);
                        // Convert mọi thứ (kể cả số) sang string để tìm kiếm
                        if (val != null && val.ToString().ToLower().Contains(keyword))
                            return true;
                    }
                    return false; // Nếu quét hết các cột không có thì bỏ qua dòng này
                }).ToList();

                // Đẩy kết quả đã lọc lên DataGridView thông qua BindingSource
                bs.DataSource = ketQua;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}