
using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Helper;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{

    public partial class frmChiTietCongViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource todoBindingSource = new BindingSource();
        int _maPhanCong; // ID kết nối bản ghi Phân công cụ thể
        bool xuLyThem = false;

        public frmChiTietCongViec(int maPhanCong, bool xylythem = false)
        {
            InitializeComponent();
            this._maPhanCong = maPhanCong;
            this.xuLyThem = xylythem;
            LoadData();
        }

        private void frmChiTietCongViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);
            LoadData();
            BatTatChucNang(false);

            if (xuLyThem)
            {
                btnThem_Click(sender, e);
            }
        }

        private void cboTenLich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            context = new Quan_Li_Lich_Lam_DbContext();

            // 1. Tìm thông tin Phân công để hiện lên giao diện
            var info = context.Chi_Tiet_Phan_Cong
                              .Include(p => p.Nhan_Vien)
                              .Include(p => p.Lich_Lam_Viec)
                              .FirstOrDefault(p => p.MaPhanCong == _maPhanCong);

            if (info != null)
            {
                var listLich = new List<Lich_Lam_Viec> { info.Lich_Lam_Viec };
                cboTenLich.DataSource = listLich;
                cboTenLich.DisplayMember = "TieuDe";
                cboTenLich.ValueMember = "MaLich";
                cboTenLich.Enabled = false;

                lblNhanVien.Text = info.Nhan_Vien.HoTen;
            }

            // 2. Lấy danh sách đầu việc của bản ghi phân công này
            var list = context.Chi_Tiet_Cong_Viecs
                              .Where(t => t.MaPhanCong == _maPhanCong)
                              .ToList();

            todoBindingSource.DataSource = list;
            dataGridView.DataSource = todoBindingSource;

            ThietLapBinding();

            string[] hideCols = { "Chi_tiet_phan_cong", "MaPhanCong", "MaLich", "Mã Công Việc" };
            foreach (var col in hideCols)
                if (dataGridView.Columns[col] != null) dataGridView.Columns[col].Visible = false;
        }

        private void ThietLapBinding()
        {
            txtTenCongViec.DataBindings.Clear();
            txtTenCongViec.DataBindings.Add("Text", todoBindingSource, "TenDauViec", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtTenCongViec.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            if (dataGridView.Columns["TrangThai"] != null)
            {
                dataGridView.Columns["TrangThai"].ReadOnly = !giaTri;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            todoBindingSource.AddNew();
            txtTenCongViec.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCongViec.Text)) return;

            if (xuLyThem)
            {
                var moi = new Chi_Tiet_Cong_Viec
                {
                    MaPhanCong = _maPhanCong, // Gán trực tiếp ID phân công
                    TenDauViec = txtTenCongViec.Text.Trim(),
                    TrangThai = false
                };
                context.Chi_Tiet_Cong_Viecs.Add(moi);
            }
            else
            {
                var current = (Chi_Tiet_Cong_Viec)todoBindingSource.Current;
                var sua = context.Chi_Tiet_Cong_Viecs.Find(current.MaChiTiet);
                if (sua != null) sua.TenDauViec = txtTenCongViec.Text.Trim();
            }

            context.SaveChanges();
            LoadData();
            BatTatChucNang(false);
            xuLyThem = false;

            context.CapNhatTienDoTuDong(this._maPhanCong);

            DataHelper.WriteLog("Cập nhật đầu việc", $"Đã {(xuLyThem ? "thêm mới" : "cập nhật")} đầu việc '{txtTenCongViec.Text}' cho phân công ID {_maPhanCong}.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (todoBindingSource.Current == null) return;
            if (MessageBox.Show("Xóa việc này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var current = (Chi_Tiet_Cong_Viec)todoBindingSource.Current;
                var xoa = context.Chi_Tiet_Cong_Viecs.Find(current.MaChiTiet);
                context.Chi_Tiet_Cong_Viecs.Remove(xoa);
                context.SaveChanges();
                LoadData();
                DataHelper.WriteLog("Xóa đầu việc", $"Đã xóa đầu việc '{current.TenDauViec}' (ID {current.MaChiTiet}) khỏi phân công ID {_maPhanCong}.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (todoBindingSource.Current == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            todoBindingSource.CancelEdit();
            LoadData();
            BatTatChucNang(false);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hiển thị tên lịch và nhân viên cho mọi dòng (vì form này chỉ phục vụ 1 cặp PC)
            if (dataGridView.Columns[e.ColumnIndex].Name == "TenLich") e.Value = cboTenLich.Text;
            if (dataGridView.Columns[e.ColumnIndex].Name == "NhanVien") e.Value = lblNhanVien.Text;

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.RowIndex >= 0)
            {
                // Kết thúc Edit để lấy giá trị mới nhất
                dataGridView.EndEdit();

                var current = (Chi_Tiet_Cong_Viec)todoBindingSource.Current;
                if (current != null)
                {
                    // Cập nhật vào DB ngay lập tức
                    var item = context.Chi_Tiet_Cong_Viecs.Find(current.MaChiTiet);
                    if (item != null)
                    {
                        item.TrangThai = (bool)dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
