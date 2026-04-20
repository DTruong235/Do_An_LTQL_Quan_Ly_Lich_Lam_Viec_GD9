using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmDonNghiPhep : frmBase
    {
        public frmDonNghiPhep()
        {
            InitializeComponent();
        }

        Quan_Li_Lich_Lam_DbContext db = new Quan_Li_Lich_Lam_DbContext();
        BindingSource bsDon = new BindingSource();

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDonNghiPhep_Load(object sender, EventArgs e)
        {
            SetupGiaoDien(this);
            LoadNhanVien();
            LoadDon();
            if (Program.CurrentUser.MaQuyen == 0)
            {
                btnDuyet.Enabled = false;
                btnTuChoi.Enabled = false;

            }
        }

        void LoadNhanVien()
        {
            if (Program.CurrentUser.MaQuyen == 0)
            {
                cboNhanVien.DataSource = db.Nhan_Vien
                    .Where(x => x.MaNhanVien == 0)
                    .ToList();

                cboNhanVien.Enabled = false;
            }
            else
            {
                cboNhanVien.DataSource = db.Nhan_Vien.ToList();
            }

            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        void LoadDon()
        {
            var query = db.DonNghiPheps.AsQueryable();
            if (Program.CurrentUser.MaQuyen == 0)
            {
                query = query.Where(l => l.MaNhanVien == 0);
            }
            bsDon.DataSource = db.DonNghiPheps
                .Select(x => new
                {
                    x.Id,
                    HoTen = x.Nhan_Vien.HoTen,
                    x.NgayBatDau,
                    x.NgayKetThuc,
                    x.LyDo,
                    TrangThai = x.TrangThai
                }).ToList();

            dataGridView.DataSource = bsDon;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                int val = Convert.ToInt32(e.Value);

                if (val == 0)
                {
                    e.Value = "Chờ";
                    e.CellStyle.ForeColor = Color.SandyBrown;
                }
                else if (val == 1)
                {
                    e.Value = "Đã duyệt";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Từ chối";
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtpKetThuc.Value < dtpBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu");
                return;
            }

            DonNghiPhep d = new DonNghiPhep()
            {
                MaNhanVien = (int)cboNhanVien.SelectedValue,
                NgayBatDau = dtpBatDau.Value,
                NgayKetThuc = dtpKetThuc.Value,
                LyDo = txtLyDo.Text,
                TrangThai = 0
            };

            db.DonNghiPheps.Add(d);
            db.SaveChanges();

            LoadDon();
        }

        void UpdateTrangThai(int trangThai)
        {
            if (dataGridView.CurrentRow == null) return;

            int id = (int)dataGridView.CurrentRow.Cells["ID"].Value;

            var d = db.DonNghiPheps.Find(id);
            if (d == null) return;

            if (d.TrangThai != 0)
            {
                MessageBox.Show("Đơn này đã xử lý rồi!");
                return;
            }

            d.TrangThai = trangThai;
            db.SaveChanges();

            LoadDon();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            UpdateTrangThai(1);
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            UpdateTrangThai(2);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            new frmInDonNghiPhep(id).ShowDialog();
        }
    }
}

