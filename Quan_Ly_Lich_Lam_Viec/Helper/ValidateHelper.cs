using System.Text.RegularExpressions;

namespace Quan_Ly_Lich_Lam_Viec.Helper
{
    class ValidateHelper
    {
        //===FORM NHÂN VIÊN====//
        public static bool KiemTraEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool KiemTraSoDienThoai(string soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(soDienThoai)) return false;
            return Regex.IsMatch(soDienThoai, @"^0\d{9}$");
        }

        //===FORM LỊCH LÀM VIỆC====//
        public static bool KiemTraTieuDe(string tieuDe)
        {
            return !string.IsNullOrWhiteSpace(tieuDe) && tieuDe.Length <= 200;
        }
        public static bool KiemTraNgayThang(DateTime startDate, DateTime endDate)
        {
            return endDate > startDate;
        }

        public static bool KiemTraSucChua(decimal soNhanVien, int sucChua)
        {
            return soNhanVien <= sucChua;
        }

        //==FORMPHANCONG===//

    }
}
