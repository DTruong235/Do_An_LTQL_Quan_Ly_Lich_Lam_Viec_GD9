namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmTimKiem : frmBase
    {
        // Thuộc tính để Form cha lấy kết quả sau khi đóng Popup
        public string TuKhoa { get; set; } = "";

        public frmTimKiem()
        {
            InitializeComponent();
            SetupGiaoDien(this);
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TuKhoa = txtTuKhoa.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
