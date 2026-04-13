using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmTaiKhoan : frmBase
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource tkBindingSource = new BindingSource();
        bool xuLyThem = false;

        //Biến lưu trữ danh sách tải từ Database
        private List<Tai_Khoan> _danhSachGoc;

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            LoadData();
            BatTatChucNang(false);
            tkBindingSource.AddingNew += TkBindingSource_AddingNew;
        }

        private void TkBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            // Tạo đối tượng tài khoản mới với các giá trị mặc định chuẩn
            var taiKhoanMoi = new Tai_Khoan
            {
                TrangThai = true, // Mặc định là hoạt động 
                MaQuyen = 1 // Mặc định Quyền là admin
            };
            e.NewObject = taiKhoanMoi;
        }

        private void LoadData()
        {
            context = new Quan_Li_Lich_Lam_DbContext();

            LoadComboBoxQuyen();

            // Load danh sách nhân viên cho ComboBox
            cboNhanVien.DataSource = context.Nhan_Vien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";


            // Load danh sách tài khoản
            var listTK = context.Tai_Khoan.Include(t => t.Nhan_Vien).ToList();

            _danhSachGoc = listTK.ToList();

            tkBindingSource.DataSource = context.Tai_Khoan.ToList();
            dataGridView.DataSource = tkBindingSource;

            ThietLapBinding();

            string[] colToHide = { "Nhan_Vien" };
            foreach (var col in colToHide)
            {
                if (dataGridView.Columns[col] != null) dataGridView.Columns[col].Visible = false;
            }
        }

        private void ThietLapBinding()
        {
            txtTenDangNhap.DataBindings.Clear();
            cboNhanVien.DataBindings.Clear();
            cboQuyen.DataBindings.Clear();
            chkTrangThai.DataBindings.Clear();

            txtTenDangNhap.DataBindings.Add("Text", tkBindingSource, "Username", true);
            cboNhanVien.DataBindings.Add("SelectedValue", tkBindingSource, "MaNhanVien", true);
            cboQuyen.DataBindings.Add("SelectedValue", tkBindingSource, "MaQuyen", true);
            chkTrangThai.DataBindings.Add("Checked", tkBindingSource, "TrangThai", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboNhanVien.Enabled = giaTri;
            cboQuyen.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true); // Mở khóa để nhập
            chkTrangThai.Enabled = false;

            tkBindingSource.AddNew(); // Thêm dòng mới vào BindingSource
            cboNhanVien.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            // Nếu là thêm mới thì bắt buộc nhập mật khẩu
            if (xuLyThem && string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                tkBindingSource.EndEdit();
                var tkHienTai = (Tai_Khoan)tkBindingSource.Current;

                if (xuLyThem)
                {
                    // --- KIỂM TRA TRÙNG TÊN ĐĂNG NHẬP ---
                    bool biTrung = context.Tai_Khoan.Any(tk => tk.Username == txtTenDangNhap.Text.Trim());
                    if (biTrung)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    // Mã hóa mật khẩu trước khi thêm mới
                    tkHienTai.Password = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text.Trim());
                    context.Tai_Khoan.Add(tkHienTai);
                }
                else
                {
                    // --- XỬ LÝ KHI SỬA ---
                    // Nếu người dùng có nhập vào ô mật khẩu thì mới mã hóa và cập nhật mật khẩu mới
                    if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {
                        tkHienTai.Password = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text.Trim());
                    }

                    context.Entry(tkHienTai).State = EntityState.Modified;
                }


                context.SaveChanges();
                MessageBox.Show("Lưu thông tin tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Nạp lại dữ liệu lên lưới
                BatTatChucNang(false); // Khóa các điều khiển nhập liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tkBindingSource.Current == null) return;
            xuLyThem = false;
            BatTatChucNang(true); // Mở khóa để sửa
            txtTenDangNhap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có dòng nào đang được chọn không
            if (tkBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tkHienTai = (Tai_Khoan)tkBindingSource.Current;


            if (tkHienTai.Username == Program.CurrentUser.Username)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập vào hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 3. Xác nhận xóa
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản [{tkHienTai.Username}] không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    context.Tai_Khoan.Remove(tkHienTai);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Nạp lại danh sách lên lưới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            tkBindingSource.CancelEdit();
            LoadData();
            BatTatChucNang(false);
        }

        private void LoadComboBoxQuyen()
        {

            var danhSachQuyen = new[] {
                new { TenQuyen = "Quản lý", Ma = 1 },
                new { TenQuyen = "Nhân viên", Ma = 0 }
            }.ToList();

            cboQuyen.DataSource = danhSachQuyen;
            cboQuyen.DisplayMember = "TenQuyen";
            cboQuyen.ValueMember = "ma";
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "MaNhanVien" && e.Value != null)
            {
                int maNV = (int)e.Value;
                var nv = context.Nhan_Vien.FirstOrDefault(n => n.MaNhanVien == maNV);

                if (nv != null)
                {
                    e.Value = nv.HoTen; // Hiển thị Họ tên thay vì số ID
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "MaQuyen" && e.Value != null)
            {
                int maQuyen = (int)e.Value;
                // Theo logic của bạn: 1 là Quản lý, 0 là Nhân viên
                e.Value = (maQuyen == 1) ? "Quản lý" : "Nhân viên";
                e.FormattingApplied = true;
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                e.Value = (bool)e.Value ? "Đang hoạt động" : "Không hoạt động";
                e.FormattingApplied = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem f = new frmTimKiem())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string keyword = f.TuKhoa.Trim();

                    // Gọi hàm Helper bên frmBase
                    bool locThanhCong = LocDuLieuLINQ(tkBindingSource, _danhSachGoc, keyword);

                    if (locThanhCong)
                    {
                        if (string.IsNullOrEmpty(keyword))
                        {
                            // Nếu user xóa trắng tìm kiếm -> Phục hồi Binding gốc của EF
                            tkBindingSource.DataSource = context.Tai_Khoan.Local.ToBindingList();
                            MessageBox.Show("Đã hủy lọc, hiển thị toàn bộ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Báo cáo thành công
                            MessageBox.Show($"Đã lọc xong các dòng chứa từ khóa: '{keyword}'", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}