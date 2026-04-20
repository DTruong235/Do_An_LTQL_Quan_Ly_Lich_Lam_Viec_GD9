using Quan_Ly_Lich_Lam_Viec.GiaoDien;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{

    public partial class frmBase : Form
    {

        protected HelpProvider hpToanCuc;
        protected ErrorProvider err;
        protected Button currentButton = null;

        public frmBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false; // Tắt icon mặc định cho phẳng

            hpToanCuc = new HelpProvider();
            err = new ErrorProvider();
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
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

                    bool isSidebar = btn.Parent != null && btn.Parent.Name.ToLower().Contains("sidebar");

                    // ===== BUTTON TRONG SIDEBAR =====
                    if (isSidebar)
                    {
                        btn.BackColor = PrimaryColor;
                        btn.ForeColor = BackColorTheme;
                        btn.FlatAppearance.BorderSize = 0;

                        if (btn.Name.ToLower().Contains("dangxuat")) btn.ForeColor = Color.DarkRed;

                        btn.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(PrimaryColor, 0.1f);
                        btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(PrimaryColor, 0.2f);

                        btn.MouseEnter += (s, ev) =>
                        {
                            if (btn != currentButton)
                                btn.BackColor = ControlPaint.Dark(PrimaryColor, 0.1f);
                        };

                        btn.MouseLeave += (s, ev) =>
                        {
                            if (btn != currentButton)
                                btn.BackColor = PrimaryColor;
                        };
                    }

                    // ===== BUTTON THƯỜNG =====
                    else
                    {
                        btn.BackColor = BackColorTheme;
                        btn.FlatAppearance.BorderSize = 1;

                        string name = btn.Name.ToLower();
                        Color originalColor;

                        if (name.Contains("xoa") || name.Contains("tuchoi"))
                            originalColor = Color.Crimson;
                        else if (name.Contains("thoat"))
                            originalColor = Color.Red;
                        else if (name.Contains("them") || name.Contains("luu"))
                            originalColor = Color.SeaGreen;
                        else if (name.Contains("sua"))
                            originalColor = Color.DarkOrange;
                        else if (name.Contains("huy"))
                            originalColor = Color.DarkCyan;
                        else
                            originalColor = PrimaryColor;

                        btn.ForeColor = originalColor;
                        btn.FlatAppearance.BorderColor = originalColor;

                        btn.FlatAppearance.MouseOverBackColor = originalColor;
                        btn.FlatAppearance.MouseDownBackColor = originalColor;

                        btn.MouseEnter += (s, ev) =>
                        {
                            if (btn != currentButton)
                            {
                                btn.BackColor = originalColor;
                                btn.ForeColor = Color.White;
                            }
                        };

                        btn.MouseLeave += (s, ev) =>
                        {
                            if (btn != currentButton)
                            {
                                btn.BackColor = BackColorTheme;
                                btn.ForeColor = originalColor;
                            }
                        };
                    }
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

                    string name = lbl.Name.ToLower();

                    if (name.Contains("tong") || name.Contains("title"))
                    {
                        lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                        lbl.ForeColor = BackColorTheme;
                    }
                    else if (name.Contains("header"))
                    {
                        lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
                        lbl.ForeColor = PrimaryColor;
                    }
                    else
                    {
                        lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular);
                    }
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
                    string name = pnl.Name.ToLower();

                    if (name.Contains("sidebar"))
                    {
                        pnl.BackColor = PrimaryColor;
                        pnl.ForeColor = TextColorTheme;
                    }
                    else if (!name.Contains("card"))
                    {
                        pnl.BackColor = BackColorTheme;
                        pnl.ForeColor = TextColorTheme;
                    }
                }

                // -- XỬ LÝ PICTUREBOX (HÌNH ẢNH) --
                else if (ctrl is PictureBox pic)
                {
                    pic.BackColor = Color.Transparent;
                    bool isSidebar = pic.Parent != null && pic.Parent.Name.ToLower().Contains("sidebar");

                    if (isSidebar)
                    {
                        pic.BackColor = PrimaryColor;
                    }
                    else
                    {
                        pic.BackColor = BackColorTheme;
                    }
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

        protected void DangKyValidationTxt(TextBox txt, Func<string, bool> checkFunc, string errorMsg)
        {
            // Khi đang gõ: Đổi màu nền
            txt.TextChanged += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.BackColor = Color.White;
                    err.SetError(txt, "");
                    return;
                }

                if (checkFunc(txt.Text))
                {
                    txt.BackColor = Color.White;
                    err.SetError(txt, "");
                }
                else
                {
                    txt.BackColor = Color.MistyRose; // Màu đỏ nhạt
                    err.SetError(txt, errorMsg);
                }
            };

            // Khi rời đi: Khóa Focus nếu sai
            txt.Validating += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txt.Text) && !checkFunc(txt.Text))
                {
                    e.Cancel = true; // Chặn không cho thoát ô này
                }
            };
        }


        protected void DangKyValidationCbo(ComboBox cbo, Func<bool> checkFunc, string errorMsg)
        {
            // Bắt sự kiện khi người dùng chọn một mục khác trong danh sách
            cbo.SelectedIndexChanged += (s, e) =>
            {
                if (checkFunc())
                {
                    cbo.BackColor = Color.White;
                    err.SetError(cbo, "");
                }
                else
                {
                    cbo.BackColor = Color.MistyRose;
                    err.SetError(cbo, errorMsg);
                }
            };

            // Khóa Focus nếu rời đi mà chưa chọn đúng
            cbo.Validating += (s, e) =>
            {
                if (!checkFunc())
                {
                    e.Cancel = true;
                }
            };
        }


        protected void DangKyValidationNum(NumericUpDown num, Func<decimal, bool> checkFunc, string errorMsg)
        {
            // Bắt sự kiện khi con số thay đổi
            num.ValueChanged += (s, e) =>
            {
                if (checkFunc(num.Value))
                {
                    num.BackColor = Color.White;
                    err.SetError(num, "");
                }
                else
                {
                    num.BackColor = Color.MistyRose;
                    err.SetError(num, errorMsg);
                }
            };

            num.KeyUp += (s, e) =>
            {
                decimal giaTriDangGo = 0;
                // Lấy cái chữ đang gõ ráng ép sang kiểu số. Nếu xóa rỗng thì mặc định là 0
                if (!string.IsNullOrWhiteSpace(num.Text))
                {
                    decimal.TryParse(num.Text, out giaTriDangGo);
                }
                if (checkFunc(num.Value))
                {
                    num.BackColor = Color.White;
                    err.SetError(num, "");
                }
                else
                {
                    num.BackColor = Color.MistyRose;
                    err.SetError(num, errorMsg);
                }
            };

            // Khóa Focus nếu rời đi mà con số không hợp lệ
            num.Validating += (s, e) =>
        {
            if (!checkFunc(num.Value))
            {
                e.Cancel = true;
            }
        };
        }

        protected void DangKyValidationDate(DateTimePicker dtpBD, DateTimePicker dtpKT, Func<DateTime, DateTime, bool> checkFunc, string errorMsg)
        {
            // Tạo 1 hàm xử lý chung, vì sửa ô Bắt Đầu hay Kết Thúc thì cũng phải kiểm tra lại
            void KiemTraHopLe(object sender, EventArgs e)
            {
                if (checkFunc(dtpBD.Value, dtpKT.Value))
                {
                    err.SetError(dtpKT, ""); // Hợp lệ -> Tắt cảnh báo
                    err.SetError(dtpBD, "");
                }
                else
                {
                    // Sai -> Đặt icon cảnh báo (thường đặt ở ô Kết thúc cho dễ nhìn)
                    err.SetError(dtpKT, errorMsg);
                }
            }
            ;

            // Gắn hàm kiểm tra vào sự kiện thay đổi của CẢ 2 Ô
            dtpBD.ValueChanged += KiemTraHopLe;
            dtpKT.ValueChanged += KiemTraHopLe;

            // Khóa Focus khi rời khỏi ô Kết Thúc mà bị lỗi
            dtpKT.Validating += (s, e) =>
            {
                if (!checkFunc(dtpBD.Value, dtpKT.Value))
                {
                    e.Cancel = true;
                }
            };
        }

    }
}