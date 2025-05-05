using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAL;

namespace BUS
{
    public class BUS_GiaoVien
    {
        DAL_GiaoVien dal_GiaoVien = new DAL_GiaoVien();
        public List<DAO_GiaoVien> GetAllMaGiaoVien() => dal_GiaoVien.GetAllGiaoVien();
        //
        public List<string> getAllMaCoSo() => dal_GiaoVien.GetAllMaCoSo();

        public void Them(GiaoVien gv) => dal_GiaoVien.Them(gv);
        public void Sua(GiaoVien gv) => dal_GiaoVien.CapNhat(gv);
        public void Xoa(string gv) => dal_GiaoVien.Xoa(gv);

        //Kiểm tra các lỗi nhập sai
        public bool IsValidGiaoVien(GiaoVien gv, out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(gv.MaGiaoVien))
                message = "Mã giáo viên không được để trống.";
            else if (string.IsNullOrWhiteSpace(gv.HoTen) || gv.HoTen.Length < 2)
                message = "Họ tên không hợp lệ.";
            else if (!System.Text.RegularExpressions.Regex.IsMatch(gv.HoTen, @"^[\p{L}\s]+$"))
                message = "Họ tên không được chứa số hoặc ký tự đặc biệt.";
            else if (!System.Text.RegularExpressions.Regex.IsMatch(gv.Email ?? "", @"^[\w\.-]+@[\w\.-]+\.\w{2,4}$"))
                message = "Email không đúng định dạng.";
            else if (string.IsNullOrWhiteSpace(gv.SoDienThoai) || gv.SoDienThoai.Length < 9)
                message = "Số điện thoại không hợp lệ.";
            else if (string.IsNullOrWhiteSpace(gv.MaCoSo))
                message = "Mã cơ sở không được để trống.";

            return string.IsNullOrEmpty(message);
        }

        //hàm làm chuẩn họ tên
        public string ChuanHoaHoTen(string hoten)
        {
            if (string.IsNullOrWhiteSpace(hoten))
                return "";

            // Xóa khoảng trắng dư và tách từ
            var words = hoten.Trim().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Viết hoa chữ cái đầu mỗi từ
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 0)
                {
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }

            return string.Join(" ", words);
        }


    }
}
