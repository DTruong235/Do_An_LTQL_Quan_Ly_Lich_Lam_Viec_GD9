using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Helper;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmLichLamViec : frmBase
    {
        public frmLichLamViec()
        {
            InitializeComponent();
            lichBindingSource.CurrentChanged += (s, e) => KiemTraVaHienThiThongTin();
            numSoLuongDuKien.ValueChanged += (s, e) => KiemTraVaHienThiThongTin();
            cboDiaDiem.SelectedIndexChanged += (s, e) => KiemTraVaHienThiThongTin();
        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        public bool xuLyThem = false;

        //Biến lưu trữ danh sách tải từ Database
        private List<Lich_Lam_Viec> _danhSachGoc;

        public bool boLocSapTre { get; set; } = false;

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            DangKyValidationTxt(txtTieuDe, ValidateHelper.KiemTraTieuDe, "Tiêu đề phải chứa ít hơn 200 ký tự");

            DangKyValidationNum(
                numSoLuongDuKien,
                (soLuongGoVao) =>
                {

                    if (cboDiaDiem.SelectedValue is int maDiaDiem)
                    {
                        var maDD = Convert.ToInt32(cboDiaDiem.SelectedValue);
                        var phong = context.Dia_Diem.Find(maDD);
                        if (phong != null)
                        {
                            return ValidateHelper.KiemTraSucChua(soLuongGoVao, phong.SucChua);
                        }
                    }
                    return true;
                },
                "Số lượng người quá tải");

            DangKyValidationCbo(cboDiaDiem, () => CheckDiaDiemHienTai(), "Địa điểm đã có lịch khác sử dụng trong khoảng thời gian này");
            DangKyValidationDate(dtpBatDau, dtpKetThuc, (ngayBD, ngayKT) => ValidateHelper.KiemTraNgayThang(dtpBatDau.Value, dtpKetThuc.Value), "Ngày kết thúc phải lớn hơn ngày bắt đầu");



            SetupGiaoDien(this);
            BatTatChucNang(false); // Khóa các ô nhập khi mới mở
            LoadData(); // Tải dữ liệu lên

            if (xuLyThem == true) btnThem.PerformClick();
        }

        private void BatTatChucNang(bool bat)
        {
            // Nhóm nút lệnh
            btnLuu.Enabled = bat;
            btnHuyBo.Enabled = bat;
            btnThem.Enabled = !bat;
            btnSua.Enabled = !bat;
            btnXoa.Enabled = !bat;

            // Nhóm nhập liệu
            txtTieuDe.Enabled = bat;
            txtNoiDung.Enabled = bat;
            dtpBatDau.Enabled = bat;
            dtpKetThuc.Enabled = bat;
            cboLoaiCongViec.Enabled = bat;
            cboDiaDiem.Enabled = bat;
            numSoLuongDuKien.Enabled = bat;
        }

        BindingSource lichBindingSource = new BindingSource();

        private void LoadData()
        {

            // Nó xóa bỏ mọi thay đổi lỗi/rác đang nằm trong bộ nhớ
            context = new Quan_Li_Lich_Lam_DbContext();

            // Đổ vào BindingSource (Giữ nguyên)
            lichBindingSource.DataSource = context.Lich_Lam_Viec.Local.ToBindingList();
            dataGridView.DataSource = lichBindingSource;

            if (lichBindingSource.Count > 0)
            {
                lichBindingSource.Position = 0; // Đưa con trỏ BindingSource về vị trí đầu tiên
                                                // Đảm bảo Grid cũng chọn đúng dòng đó trên giao diện
                dataGridView.Rows[0].Selected = true;
            }

            // Nạp dữ liệu cho ComboBox (Giữ nguyên)
            cboLoaiCongViec.DataSource = context.Loai_Cong_Viec.ToList();
            cboDiaDiem.DataSource = context.Dia_Diem.ToList();

            // Load dữ liệu nguồn cho ComboBox
            cboDiaDiem.DataSource = context.Dia_Diem.ToList();
            cboDiaDiem.DisplayMember = "TenDiaDiem";
            cboDiaDiem.ValueMember = "MaDiaDiem";

            cboLoaiCongViec.DataSource = context.Loai_Cong_Viec.ToList();
            cboLoaiCongViec.DisplayMember = "TenLoai";
            cboLoaiCongViec.ValueMember = "MaLoaiCV";

            var query = context.Lich_Lam_Viec
                                  .Include(l => l.Loai_Cong_Viec)
                                  .Include(l => l.Dia_Diem)
                                  .Include(l => l.Chi_Tiet_Phan_Cong)
                                  .AsQueryable();

            if (boLocSapTre == true)
            {
                DateTime now = DateTime.Now;
                query = query.Where(l =>
                    l.ThoiGianKetThuc >= now &&
                    l.ThoiGianKetThuc <= now.AddDays(2) &&
                    (!l.Tien_Do_Cong_Viec.Any() || l.Tien_Do_Cong_Viec.OrderByDescending(t => t.NgayCapNhat)
                                                                      .FirstOrDefault().PhanTramHoanThanh < 100));
            }

            if (Program.CurrentUser.MaQuyen == 0)
            {
                query = query.Where(l => l.Chi_Tiet_Phan_Cong.Any(pc => pc.MaNhanVien == Program.CurrentUser.MaNhanVien));
            }

            var listLich = query.OrderByDescending(l => l.ThoiGianBatDau).ToList();

            _danhSachGoc = query.ToList();

            lichBindingSource.DataSource = context.Lich_Lam_Viec.Local.ToBindingList();
            dataGridView.DataSource = lichBindingSource;

            // Binding lên các ô nhập liệu (Sử dụng lichBindingSource chung)
            txtTieuDe.DataBindings.Clear();
            txtTieuDe.DataBindings.Add("Text", lichBindingSource, "TieuDe", true, DataSourceUpdateMode.OnPropertyChanged);

            numSoLuongDuKien.DataBindings.Clear();
            numSoLuongDuKien.DataBindings.Add("Value", lichBindingSource, "SoLuongDuKien", true, DataSourceUpdateMode.OnPropertyChanged);

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", lichBindingSource, "NoiDung", true, DataSourceUpdateMode.OnPropertyChanged);

            dtpBatDau.DataBindings.Clear();
            dtpBatDau.DataBindings.Add("Value", lichBindingSource, "ThoiGianBatDau", true, DataSourceUpdateMode.OnPropertyChanged);

            dtpKetThuc.DataBindings.Clear();
            dtpKetThuc.DataBindings.Add("Value", lichBindingSource, "ThoiGianKetThuc", true, DataSourceUpdateMode.OnPropertyChanged);

            numSoLuongDuKien.DataBindings.Clear();
            numSoLuongDuKien.DataBindings.Add("Value", lichBindingSource, "SoLuongDuKien", true, DataSourceUpdateMode.OnPropertyChanged);

            cboLoaiCongViec.DataBindings.Clear();
            cboLoaiCongViec.DataBindings.Add("SelectedValue", lichBindingSource, "MaLoaiCV", true, DataSourceUpdateMode.OnPropertyChanged);

            cboDiaDiem.DataBindings.Clear();
            cboDiaDiem.DataBindings.Add("SelectedValue", lichBindingSource, "MaDiaDiem", true, DataSourceUpdateMode.OnPropertyChanged);

            // 4.ột ID và các Lis Cấu hình hiển thị Grid
            // Ẩn các ct quan hệ
            string[] colToHide = { "MaLich", "MaLoaiCV", "Loai_Cong_Viec", "Dia_Diem",
                           "Chi_Tiet_Phan_Cong", "Tien_Do_Cong_Viec", "Chi_Tiet_Cong_Viecs"};
            foreach (var colName in colToHide)
            {
                if (dataGridView.Columns[colName] != null) dataGridView.Columns[colName].Visible = false;
            }

            err.Clear();
        }

        private bool KiemTraDuLieu()
        {

            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                MessageBox.Show("Tiêu đề lịch không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieuDe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Nội dung lịch không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return false;
            }

            if (!ValidateHelper.KiemTraTieuDe(txtTieuDe.Text))
            {
                MessageBox.Show("Tiêu đề lịch phải ít hơn 200 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieuDe.Focus();
                return false;
            }

            DateTime batDau = dtpBatDau.Value;
            DateTime ketThuc = dtpKetThuc.Value;

            if (!ValidateHelper.KiemTraNgayThang(batDau, ketThuc))
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Kiểm tra sức chứa
            int maDD = Convert.ToInt32(cboDiaDiem.SelectedValue);
            var phong = context.Dia_Diem.Find(maDD);

            if (phong != null)
            {
                int soLuongDuKien = (int)numSoLuongDuKien.Value;

                if (!ValidateHelper.KiemTraSucChua(soLuongDuKien, phong.SucChua))
                {
                    MessageBox.Show($"Số lượng dự kiến ({soLuongDuKien}) vượt quá sức chứa của địa điểm này! (Sức chứa tối đa: {phong.SucChua})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numSoLuongDuKien.Focus();
                    return false;
                }
            }

            //Kiểm tra trùng thời gian, nhân viên và địa điểm
            if (MaDiaDiem != null)
            {
                if (!CheckDiaDiemHienTai())
                {
                    MessageBox.Show("Địa điểm này đã có lịch khác sử dụng trong khoảng thời gian này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboDiaDiem.Focus();
                    return false;
                }
            }

            return true;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridView.Columns[e.ColumnIndex].Name == "MaDiaDiem" && e.Value != null)
            {
                // Thay vì hiện số ID, ta hiện tên loại
                var id = (int)e.Value;
                var item = context.Dia_Diem.Find(id);
                if (item != null) e.Value = item.TenDiaDiem;
            }

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Xóa trắng để nhập mới
            lichBindingSource.AddNew();

            var lichMoi = (Lich_Lam_Viec)lichBindingSource.Current;

            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now.AddHours(1); // Mặc định họp 1 tiếng

            txtTieuDe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime batDau = dtpBatDau.Value;
                DateTime ketThuc = dtpKetThuc.Value;

                KiemTraDuLieu();

                int? maDiaDiem = cboDiaDiem.SelectedValue as int?;
                int maLichHienTai = xuLyThem ? 0 : Convert.ToInt32(dataGridView.CurrentRow.Cells["MaLich"].Value);

                Lich_Lam_Viec lich;
                if (xuLyThem)
                {
                    lich = new Lich_Lam_Viec();
                    context.Lich_Lam_Viec.Add(lich);
                }
                else
                {
                    lich = context.Lich_Lam_Viec.Find(maLichHienTai);
                    if (lich == null) return;
                }

                // Gán dữ liệu
                lich.TieuDe = txtTieuDe.Text;
                lich.NoiDung = txtNoiDung.Text;
                lich.ThoiGianBatDau = batDau;
                lich.ThoiGianKetThuc = ketThuc;
                lich.SoLuongDuKien = (int)numSoLuongDuKien.Value;
                lich.MaLoaiCV = (int)cboLoaiCongViec.SelectedValue;
                lich.MaDiaDiem = maDiaDiem;

                context.SaveChanges(); // ID sẽ tự sinh và nạp vào đối tượng 'lich'

                // 4. Hậu xử lý
                var dr = MessageBox.Show("Lưu lịch thành công! Bạn có muốn phân công nhân sự ngay không?",
                                         "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    frmPhanCong f = new frmPhanCong(lich.MaLich, true);
                    f.ShowDialog();
                }

                LoadData();

                DataHelper.WriteLog(xuLyThem ? "Thêm Lịch" : "Sửa Lịch", $"Đã {(xuLyThem ? "thêm" : "sửa")} lịch: {lich.TieuDe}");
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaLich"].Value);
                    Lich_Lam_Viec lich = context.Lich_Lam_Viec.Find(id);
                    if (lich != null)
                    {
                        context.Lich_Lam_Viec.Remove(lich);
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa thành công lịch " + lich.TieuDe, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataHelper.WriteLog("Xóa Lịch", $"Đã xóa lịch: {lich.TieuDe}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (Có thể do lịch này đã có nhân viên hoặc báo cáo đi kèm).\nLỗi: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            lichBindingSource.CancelEdit();

            BatTatChucNang(false);
            LoadData(); // Reset lại dữ liệu ban đầu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckDiaDiemHienTai()
        {
            if (!btnLuu.Enabled)
            {
                err.Clear();
                return true;
            }

            if (cboDiaDiem.SelectedValue == null) return true;

            if (!(cboDiaDiem.SelectedValue is int maDD))
                return true;

            DateTime batDau = dtpBatDau.Value;
            DateTime ketThuc = dtpKetThuc.Value;

            // Giờ kết thúc phải lớn hơn giờ bắt đầu thì check mới có nghĩa
            if (batDau >= ketThuc) return false;

            int? maLichHienTai = null;
            if (!xuLyThem && dataGridView.CurrentRow != null)
            {
                maLichHienTai = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaLich"].Value);
            }

            // Kiểm tra trùng: (S1 < E2) AND (S2 < E1)
            bool biTrung = context.Lich_Lam_Viec.Any(l =>
                l.MaDiaDiem == maDD &&
                (maLichHienTai == null || l.MaLich != maLichHienTai) &&
                batDau < l.ThoiGianKetThuc &&
                ketThuc > l.ThoiGianBatDau);

            return !biTrung;
        }


        private void KiemTraVaHienThiThongTin()
        {
            if (cboDiaDiem.SelectedValue is int maDD)
            {
                if (lichBindingSource.Current == null) return;
                // 1. Tìm thông tin phòng trong Database
                var phong = context.Dia_Diem.Find(maDD);
                if (phong != null)
                {
                    // Hiển thị thông tin nhanh
                    lblThongTinPhong.Text = $"Sức chứa: {phong.SucChua} | Thiết bị: {phong.ThietBi}";

                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nhấn vào hàng dữ liệu và đúng cột TinhTrang
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "TinhTrang")
            {
                var lichChon = dataGridView.Rows[e.RowIndex].DataBoundItem as Lich_Lam_Viec;

                if (lichChon != null)
                {
                    // Lấy nội dung chữ trong ô vừa nhấn
                    string giaTriO = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

                    // Kiểm tra trạng thái
                    bool kichHoatThem = giaTriO.Contains("Thêm phân công");

                    // Mở form và truyền trạng thái vào
                    frmPhanCong f = new frmPhanCong(lichChon.MaLich, kichHoatThem);
                    f.ShowDialog();

                    // Load lại để cập nhật số lượng (Ví dụ: từ "Chưa" thành "Đã phân công (1)")
                    LoadData();
                }
            }
        }

        private void ImportLichLamViec(string filePath, ListBox lstLog)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Chuẩn bị Log ban đầu
                        lstLog.Visible = true;
                        lstLog.Items.Clear();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu nhập dữ liệu từ file Excel...");
                        Application.DoEvents();

                        int soDongThanhCong = 0;
                        int soDongThatBai = 0;

                        // --- BƯỚC 1: NHẬP SHEET LỊCH LÀM VIỆC ---
                        var wsLich = workbook.Worksheet(1);
                        var rowsLich = wsLich.RowsUsed().Skip(1);

                        Dictionary<int, int> mapID = new Dictionary<int, int>();
                        Dictionary<int, int> mapPhanCong = new Dictionary<int, int>(); // Map ID Phân công
                        HashSet<int> dsMaLichCanTinhTienDo = new HashSet<int>(); // Danh sách mã lịch cần tính lại %

                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang nhập dữ liệu lịch làm việc...");
                        Application.DoEvents();

                        foreach (var row in rowsLich)
                        {
                            try
                            {
                                int idExcel = row.Cell(1).GetValue<int>();
                                string tieuDe = row.Cell(2).GetValue<string>();



                                if (string.IsNullOrWhiteSpace(tieuDe)) throw new Exception("Tiêu đề rỗng");

                                var lich = new Lich_Lam_Viec
                                {
                                    TieuDe = tieuDe,
                                    NoiDung = row.Cell(3).GetValue<string>(),
                                    ThoiGianBatDau = row.Cell(4).GetDateTime(),
                                    ThoiGianKetThuc = row.Cell(5).GetDateTime(),
                                    SoLuongDuKien = row.Cell(6).GetValue<int>(),
                                    MaLoaiCV = row.Cell(7).GetValue<int>(),
                                    MaDiaDiem = row.Cell(8).GetValue<int>()
                                };

                                if (!CheckDiaDiemHienTai())
                                {
                                    throw new Exception("Vi phạm ràng buộc");
                                }

                                context.Lich_Lam_Viec.Add(lich);
                                context.SaveChanges();

                                mapID.Add(idExcel, lich.MaLich);

                                // Ghi Log thành công cho Sheet 1
                                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Lịch: {tieuDe} - thành công");
                                soDongThanhCong++;
                                lstLog.TopIndex = lstLog.Items.Count - 1;
                                Application.DoEvents();
                            }
                            catch (Exception ex)
                            {
                                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Dòng {row.RowNumber()}: Thất bại ({ex.Message})");
                                lstLog.TopIndex = lstLog.Items.Count - 1;
                                soDongThatBai++;
                                Application.DoEvents();
                            }
                        }

                        // --- BƯỚC 2: NHẬP SHEET CHI TIẾT PHÂN CÔNG ---
                        if (workbook.Worksheets.Count > 1)
                        {
                            var wsPC = workbook.Worksheet(2);
                            var rowsPC = wsPC.RowsUsed().Skip(1);

                            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang nhập dữ liệu phân công chi tiết...");
                            Application.DoEvents();

                            foreach (var row in rowsPC)
                            {
                                try
                                {
                                    int idLichExcel = row.Cell(1).GetValue<int>();
                                    int idNhanVien = row.Cell(2).GetValue<int>();
                                    string vaiTro = row.Cell(3).GetValue<string>();

                                    if (!mapID.ContainsKey(idLichExcel))
                                        throw new Exception("Không tìm thấy mã lịch tương ứng");

                                    if (!context.Nhan_Vien.Any(n => n.MaNhanVien == idNhanVien))
                                        throw new Exception("Mã nhân viên không tồn tại");

                                    var pc = new Chi_Tiet_Phan_Cong
                                    {
                                        MaLich = mapID[idLichExcel],
                                        MaNhanVien = idNhanVien,
                                        Vai_Tro = vaiTro
                                    };

                                    context.Chi_Tiet_Phan_Cong.Add(pc);
                                    context.SaveChanges();

                                    int idPhanCongExcel = row.Cell(1).GetValue<int>(); // ID cũ trong Excel
                                    mapPhanCong.Add(idPhanCongExcel, pc.MaPhanCong);   // Ghi lại: ID cũ -> ID mới trong DB

                                    // Ghi Log thành công cho Sheet 2
                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Phân công NV {idNhanVien} vào Lịch {idLichExcel} - thành công");
                                    soDongThanhCong++;
                                    lstLog.TopIndex = lstLog.Items.Count - 1;
                                    Application.DoEvents();
                                }
                                catch (Exception ex)
                                {
                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Lỗi phân công dòng {row.RowNumber()}: {ex.Message}");
                                    lstLog.TopIndex = lstLog.Items.Count - 1;
                                    soDongThatBai++;
                                    Application.DoEvents();
                                }
                            }
                        }

                        // --- BƯỚC 3: NHẬP SHEET ĐẦU VIỆC CHI TIẾT ---
                        if (workbook.Worksheets.Count > 2)
                        {
                            var wsCT = workbook.Worksheet(3); // Lấy Sheet 3
                            var rowsCT = wsCT.RowsUsed().Skip(1); // Bỏ qua tiêu đề

                            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang nhập dữ liệu công việc chi tiết...");
                            Application.DoEvents();

                            foreach (var row in rowsCT)
                            {
                                try
                                {
                                    int idLichTrongExcel = row.Cell(2).GetValue<int>(); // Cột liên kết với Sheet 1
                                    int idPhanCongTrongExcel = row.Cell(3).GetValue<int>(); // Cột liên kết với Sheet 2
                                    string tenViec = row.Cell(4).GetValue<string>();

                                    if (string.IsNullOrWhiteSpace(tenViec)) continue;

                                    // Kiểm tra xem Mã Phân Công cũ này có nằm trong Dictionary mapID đã tạo ở Bước 2 không
                                    if (mapPhanCong.ContainsKey(idPhanCongTrongExcel))
                                    {
                                        var ct = new Chi_Tiet_Cong_Viec
                                        {
                                            MaLich = mapID[idLichTrongExcel], // Lấy đúng ID mới từ sổ tay
                                            MaPhanCong = mapPhanCong[idPhanCongTrongExcel], // Lấy đúng ID mới từ sổ tay
                                            TenDauViec = tenViec.Trim(),
                                            TrangThai = row.Cell(5).GetValue<string>() == "Hoàn thành" // Chuyển chữ thành bool
                                        };

                                        context.Chi_Tiet_Cong_Viecs.Add(ct);

                                        // Tìm lại MaLich để tính % (vì Tiến độ tính theo Lịch)
                                        var pcHienTai = context.Chi_Tiet_Phan_Cong.Find(mapPhanCong[idPhanCongTrongExcel]);
                                        if (pcHienTai != null) dsMaLichCanTinhTienDo.Add(pcHienTai.MaLich);

                                        context.SaveChanges(); // Lưu từng dòng để đảm bảo tính nhất quán



                                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Công việc: {tenViec} - thành công");
                                        soDongThanhCong++;
                                    }
                                    else
                                    {
                                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Dòng {row.RowNumber()}: Không tìm thấy mã phân công tương ứng");
                                        soDongThatBai++;
                                    }

                                    // Cuộn Log xuống cuối
                                    lstLog.TopIndex = lstLog.Items.Count - 1;
                                    Application.DoEvents(); // Giúp Form không bị "treo"
                                }
                                catch (Exception ex)
                                {
                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Lỗi dòng {row.RowNumber()}: {ex.Message}");
                                    soDongThatBai++;
                                    Application.DoEvents();
                                }
                            }


                            foreach (var maLich in dsMaLichCanTinhTienDo)
                            {
                                // Gọi hàm tính toán lại % cho từng lịch
                                DataHelper.CapNhatTienDoTuDong(maLich, context);
                            }
                        }

                        transaction.Commit();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Hoàn tất quá trình nhập dữ liệu!");

                        if (soDongThatBai == 0)
                        {
                            MessageBox.Show($"Đã nhập hoàn tất thành công {soDongThanhCong} dòng!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Quá trình nhập không thành công hoàn toàn!\n" +
                                $"- Thành công: {soDongThanhCong}\n" +
                                $"- Thất bại: {soDongThatBai}\n" +
                                $"Vui lòng kiểm tra lại danh sách Log.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DataHelper.WriteLog("Import Excel", "Nhập danh sách lịch từ file Excel thành công.");

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ LỖI NGHIÊM TRỌNG: {ex.Message}");
                        MessageBox.Show("Lỗi nghiêm trọng: " + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void ExportLichLamViec(string filePath, ListBox lstLog)
        {
            try
            {
                // Hiện và làm sạch Log trước khi bắt đầu
                lstLog.Visible = true;
                lstLog.Items.Clear();
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu khởi tạo file Excel...");

                using (var workbook = new XLWorkbook())
                {

                    // --- SHEET 1: LỊCH LÀM VIỆC ---
                    var wsLich = workbook.Worksheets.Add("Lịch Làm Việc");
                    string[] header1 = { "Mã Lịch", "Tiêu Đề", "Nội dung", "Thời Gian Bắt Đầu", "Thời Gian Kết Thúc", "Số Lượng Dự Kiến", "Loại Công Việc", "Địa Điểm", "Tình Trạng" };
                    for (int h = 0; h < header1.Length; h++) wsLich.Cell(1, h + 1).Value = header1[h];

                    var listLich = context.Lich_Lam_Viec.ToList();
                    for (int i = 0; i < listLich.Count; i++)
                    {
                        int r = i + 2;
                        wsLich.Cell(r, 1).Value = listLich[i].MaLich;
                        wsLich.Cell(r, 2).Value = listLich[i].TieuDe;
                        wsLich.Cell(r, 3).Value = listLich[i].NoiDung;

                        // Xuất ngày giờ và định dạng
                        wsLich.Cell(r, 4).Value = listLich[i].ThoiGianBatDau;
                        wsLich.Cell(r, 4).Style.DateFormat.Format = "dd/mm/yyyy hh:mm";

                        wsLich.Cell(r, 5).Value = listLich[i].ThoiGianKetThuc;
                        wsLich.Cell(r, 5).Style.DateFormat.Format = "dd/mm/yyyy hh:mm";

                        wsLich.Cell(r, 6).Value = listLich[i].SoLuongDuKien;
                        wsLich.Cell(r, 7).Value = listLich[i].MaLoaiCV;
                        wsLich.Cell(r, 8).Value = listLich[i].MaDiaDiem;
                        wsLich.Cell(r, 9).Value = listLich[i].TinhTrang;

                        // Ghi Log trực tiếp cho từng dòng Lịch
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang xuất lịch làm việc: {listLich[i].TieuDe} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1; // Tự động cuộn xuống
                        Application.DoEvents(); // Cập nhật giao diện ngay
                    }
                    wsLich.Columns().AdjustToContents();

                    // --- SHEET 2: CHI TIẾT PHÂN CÔNG ---
                    var wsPC = workbook.Worksheets.Add("Chi Tiết Phân Công");
                    string[] header2 = { "Mã Phân Công", "Mã Lịch", "Tên Nhân Viên", "Vai Trò", "Đã xác nhận" };
                    for (int h = 0; h < header2.Length; h++) wsPC.Cell(1, h + 1).Value = header2[h];

                    var listPC = context.Chi_Tiet_Phan_Cong.ToList();
                    foreach (var pc in listPC)
                    {
                        int row = wsPC.LastRowUsed()?.RowNumber() + 1 ?? 2;
                        wsPC.Cell(row, 1).Value = pc.MaPhanCong;
                        wsPC.Cell(row, 2).Value = pc.MaLich;
                        wsPC.Cell(row, 3).Value = pc.MaNhanVien;
                        wsPC.Cell(row, 4).Value = pc.Vai_Tro;
                        wsPC.Cell(row, 5).Value = pc.Da_Xac_Nhan ? "Đã xác nhận" : "Chưa xác nhận";

                        // Ghi Log trực tiếp cho phân công
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Phân công NV {pc.MaNhanVien} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1;
                        Application.DoEvents();
                    }
                    wsPC.Columns().AdjustToContents();

                    // --- SHEET 3: ĐẦU VIỆC CHI TIẾT ---
                    var wsChiTiet = workbook.Worksheets.Add("Chi Tiết Công Việc");
                    string[] header3 = { "Mã Chi Tiết", "Mã Lịch", "Mã Phân Công", "Tên Đầu Việc", "Trạng Thái" };
                    for (int h = 0; h < header3.Length; h++) wsChiTiet.Cell(1, h + 1).Value = header3[h];

                    var listCT = context.Chi_Tiet_Cong_Viecs.ToList();
                    for (int i = 0; i < listCT.Count; i++)
                    {
                        int r = i + 2;
                        wsChiTiet.Cell(r, 1).Value = listCT[i].MaChiTiet;
                        wsChiTiet.Cell(r, 2).Value = listCT[i].MaLich;
                        wsChiTiet.Cell(r, 3).Value = listCT[i].MaPhanCong;
                        wsChiTiet.Cell(r, 4).Value = listCT[i].TenDauViec;
                        wsChiTiet.Cell(r, 5).Value = listCT[i].TrangThai ? "Hoàn thành" : "Chưa hoàn thành";

                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang xuất công việc: {listCT[i].TenDauViec} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1;
                        Application.DoEvents();
                    }
                    wsChiTiet.Columns().AdjustToContents();

                    // Lưu file
                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang lưu file vào đường dẫn...");
                    workbook.SaveAs(filePath);

                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] XUẤT FILE HOÀN TẤT!");

                    DataHelper.WriteLog("Export Excel", "Xuất danh sách lịch ra file Excel thành công.");
                }
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] LỖI: {ex.Message}");
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = openFileDialog.FileName;
                ImportLichLamViec(filePath, lstLog);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "LichLamViec_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = saveFileDialog.FileName;
                ExportLichLamViec(filePath, lstLog);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem f = new frmTimKiem())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string keyword = f.TuKhoa.Trim();

                    // Gọi hàm Helper bên frmBase
                    bool locThanhCong = LocDuLieuLINQ(lichBindingSource, _danhSachGoc, keyword);

                    if (locThanhCong)
                    {
                        if (string.IsNullOrEmpty(keyword))
                        {
                            // Nếu user xóa trắng tìm kiếm -> Phục hồi Binding gốc của EF
                            lichBindingSource.DataSource = context.Lich_Lam_Viec.Local.ToBindingList();
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

        private void cboDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal giaTriHienTai = numSoLuongDuKien.Value;
            numSoLuongDuKien.Value = giaTriHienTai == 1 ? 2 : 1; // Đổi số giả
            numSoLuongDuKien.Value = giaTriHienTai;
        }
    }
}
