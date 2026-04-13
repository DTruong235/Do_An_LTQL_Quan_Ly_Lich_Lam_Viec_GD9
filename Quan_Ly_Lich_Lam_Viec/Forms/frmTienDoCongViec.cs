using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmTienDoCongViec : frmBase
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource tienDoBindingSource = new BindingSource();
        bool xuLyThem = false;

        public frmTienDoCongViec()
        {
            InitializeComponent();
            checkedListBox.CheckOnClick = true;
        }

        private void frmTienDoCongViec_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);

            LoadComboBoxLich();
            LoadData();
            ThietLapBinding();
        }

        private void BatTatChucNang(bool giaTri)
        {

            cboTenLich.Enabled = !giaTri;
            txtGhiChu.Enabled = giaTri;
            checkedListBox.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;

            dataGridView.Enabled = !giaTri;
        }

        private void LoadData()
        {
            int maLichDangChon = (int)cboTenLich.SelectedValue;
            context = new Quan_Li_Lich_Lam_DbContext();

            var list = context.Tien_Do_Cong_Viec
                            .Include(t => t.Lich_Lam_Viec)
                            .Where(t => t.MaLich == maLichDangChon)
                            .ToList();

            tienDoBindingSource.DataSource = list;
            dataGridView.DataSource = tienDoBindingSource;


            BatTatChucNang(false);

            string[] colToHide = { "Lich_Lam_Viec", "MaTienDo" };
            foreach (var col in colToHide)
            {
                if (dataGridView.Columns[col] != null) dataGridView.Columns[col].Visible = false;
            }

        }

        private void ThietLapBinding()
        {
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", tienDoBindingSource, "GhiChu", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadComboBoxLich()
        {
            context = new Quan_Li_Lich_Lam_DbContext();
            var query = context.Lich_Lam_Viec.AsQueryable();

            if (Program.CurrentUser != null)
            {
                DataHelper.FilterByRole(query, "MaNhanVien");
            }
            else
            {

                MessageBox.Show("Cảnh báo: Chưa xác định thông tin đăng nhập!", "Hệ thống");
            }

            cboTenLich.DataSource = query.ToList();
            cboTenLich.DisplayMember = "TieuDe";
            cboTenLich.ValueMember = "MaLich";

            checkedListBox.Items.Clear();
        }

        private void CapNhatTienDo()
        {
            int tong = checkedListBox.Items.Count;
            if (tong == 0) { progressBar.Value = 0; lblTrangThai.Text = "N/A"; return; }

            int xong = checkedListBox.CheckedItems.Count;
            int phanTram = (int)((double)xong / tong * 100);

            progressBar.Value = phanTram;
            lblTrangThai.Text = (phanTram == 100) ? "Hoàn thành" : phanTram + "%";
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                CapNhatTienDo();
            }));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                context = new Quan_Li_Lich_Lam_DbContext();
                int maLich = (int)cboTenLich.SelectedValue;
                string GhiChu = txtGhiChu.Text;


                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var item = (Chi_Tiet_Cong_Viec)checkedListBox.Items[i];
                    var dbItem = context.Chi_Tiet_Cong_Viecs.Find(item.MaChiTiet);
                    if (dbItem != null) dbItem.TrangThai = checkedListBox.GetItemChecked(i);
                }


                int tong = checkedListBox.Items.Count;
                int xong = checkedListBox.CheckedItems.Count;
                double phanTram = (tong > 0) ? (double)xong / tong * 100 : 0;


                var tienDoExist = context.Tien_Do_Cong_Viec.FirstOrDefault(x => x.MaLich == maLich);

                if (tienDoExist == null)
                {

                    var moi = new Tien_Do_Cong_Viec
                    {
                        MaLich = maLich,
                        PhanTramHoanThanh = (int)phanTram,
                        NgayCapNhat = DateTime.Now,
                        GhiChu = GhiChu
                    };
                    context.Tien_Do_Cong_Viec.Add(moi);
                }
                else
                {

                    tienDoExist.PhanTramHoanThanh = (int)phanTram;
                    tienDoExist.NgayCapNhat = DateTime.Now;
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu tiến độ và cập nhật bảng tổng quát!", "Thành công");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }

            BatTatChucNang(false);
            DataHelper.WriteLog("Cập nhật tiến độ", $"Đã cập nhật tiến độ cho Lịch: {cboTenLich.Text} với {checkedListBox.CheckedItems.Count}/{checkedListBox.Items.Count} đầu việc hoàn thành.");
        }

        private void cboTenLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenLich.SelectedValue == null || !(cboTenLich.SelectedValue is int))
            {
                checkedListBox.DataSource = null;
                return;
            }

            int maLich = (int)cboTenLich.SelectedValue;
            context = new Quan_Li_Lich_Lam_DbContext();

            // Lấy danh sách công việc của Lịch này (phải nối qua bảng Phân công)
            var dsViec = context.Chi_Tiet_Cong_Viecs
                                .Include(t => t.Chi_Tiet_Phan_Cong)
                                .Where(t => t.Chi_Tiet_Phan_Cong.MaLich == maLich)
                                .ToList();

            // Nếu là Nhân viên, chỉ hiện việc của họ. Nếu là Admin, hiện tất cả của Lịch đó.
            if (Program.CurrentUser != null && Program.CurrentUser.MaQuyen == 0)
            {
                dsViec = dsViec.Where(t => t.Chi_Tiet_Phan_Cong.MaNhanVien == Program.CurrentUser.MaNhanVien).ToList();
            }

            if (dsViec.Count == 0)
            {
                MessageBox.Show("Lịch làm việc này hiện chưa có đầu việc nào được phân công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Nạp vào CheckedListBox
            checkedListBox.DataSource = dsViec;
            checkedListBox.DisplayMember = "TenDauViec";
            checkedListBox.ValueMember = "MaChiTiet";

            // Tự động tích vào những việc đã "Hoàn thành" từ DB
            for (int i = 0; i < dsViec.Count; i++)
            {
                bool status = dsViec[i].TrangThai;
                checkedListBox.SetItemChecked(i, status);
            }

            LoadData();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tienDoBindingSource.Current is Tien_Do_Cong_Viec current)
            {
                // Nạp danh sách việc dựa trên MaLich của dòng đang chọn
                var dsViec = context.Chi_Tiet_Cong_Viecs
                                    .Where(t => t.Chi_Tiet_Phan_Cong.MaLich == current.MaLich)
                                    .ToList();

                checkedListBox.DataSource = dsViec;
                checkedListBox.DisplayMember = "TenDauViec";
                checkedListBox.ValueMember = "MaChiTiet";

                // Cập nhật dấu tick và ProgressBar
                for (int i = 0; i < dsViec.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, dsViec[i].TrangThai);
                }

                // Cập nhật ProgressBar dựa trên giá trị % trong DB
                progressBar.Value = (int)(current.PhanTramHoanThanh);
            }
        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboTenLich.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lịch làm việc!", "Thông báo");
                    return;
                }

                context = new Quan_Li_Lich_Lam_DbContext();
                int maLich = (int)cboTenLich.SelectedValue;

                // Luôn cập nhật bảng Chi_Tiet_Cong_Viec dựa trên CheckedListBox
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var item = (Chi_Tiet_Cong_Viec)checkedListBox.Items[i];
                    var dbItem = context.Chi_Tiet_Cong_Viecs.Find(item.MaChiTiet);
                    if (dbItem != null)
                    {
                        dbItem.TrangThai = checkedListBox.GetItemChecked(i);
                    }
                }

                if (xuLyThem)
                {
                    // Trường hợp Thêm mới bản ghi tiến độ
                    var moi = new Tien_Do_Cong_Viec
                    {
                        MaLich = maLich,
                        PhanTramHoanThanh = progressBar.Value,
                        GhiChu = txtGhiChu.Text.Trim(),
                        NgayCapNhat = DateTime.Now // Lấy ngày giờ hệ thống mới nhất
                    };
                    context.Tien_Do_Cong_Viec.Add(moi);
                }
                else
                {
                    // Trường hợp Sửa bản ghi đang chọn trên Grid
                    var current = (Tien_Do_Cong_Viec)tienDoBindingSource.Current;
                    if (current != null)
                    {
                        var sua = context.Tien_Do_Cong_Viec.Find(current.MaTienDo);
                        if (sua != null)
                        {
                            sua.MaLich = maLich;
                            sua.PhanTramHoanThanh = progressBar.Value;
                            sua.GhiChu = txtGhiChu.Text.Trim();
                            sua.NgayCapNhat = DateTime.Now; // Cập nhật lại ngày mới nhất
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");

                xuLyThem = false;
                LoadData(); // Nạp lại Grid và Reset Binding
                BatTatChucNang(false); // Khóa các ô nhập liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tienDoBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi tiến độ cần xóa!", "Thông báo");
                return;
            }

            // 2. Hiện hộp thoại xác nhận (tránh xóa nhầm dữ liệu quan trọng)
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi tiến độ này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    context = new Quan_Li_Lich_Lam_DbContext();
                    var current = (Tien_Do_Cong_Viec)tienDoBindingSource.Current;

                    var itemXoa = context.Tien_Do_Cong_Viec.Find(current.MaTienDo);

                    if (itemXoa != null)
                    {
                        context.Tien_Do_Cong_Viec.Remove(itemXoa);
                        context.SaveChanges();

                        MessageBox.Show("Đã xóa bản ghi tiến độ thành công!", "Thông báo");

                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tienDoBindingSource.Current == null) return;

            xuLyThem = false;
            BatTatChucNang(true);
            cboTenLich.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            tienDoBindingSource.CancelEdit();

            LoadData();

            BatTatChucNang(false);
            xuLyThem = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "MaLich" ||
                dataGridView.Columns[e.ColumnIndex].HeaderText == "Tên Lịch")
            {
                var row = dataGridView.Rows[e.RowIndex].DataBoundItem as Tien_Do_Cong_Viec;
                if (row != null && row.Lich_Lam_Viec != null)
                {
                    e.Value = row.Lich_Lam_Viec.TieuDe;
                }
            }
        }
    }
}
