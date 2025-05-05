using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DAO;
using DAL;

namespace BUS
{
    public class BUS_HocVien
    {
        //
        DAL_HocVien dal_HocVien = new DAL_HocVien();
        //
        public List<DAO_HocVien> getAllMaHocVien() => dal_HocVien.GetAllMaHocVien();
        //
        public List<string> getAllMaCoSo() => dal_HocVien.GetAllMaCoSo();

        // ------------------------
        // VALIDATION METHODS BELOW
        // ------------------------

        public bool IsValidMaHocVien(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma)) return false;
            ma = ma.Trim();
            var pattern = @"^(?!.*  )(?!\s)(?!.*\s$)[a-zA-Z0-9]+$";
            return Regex.IsMatch(ma, pattern);
        }//đã chạy

        public bool IsValidHoTen(string hoTen)
        {
            if (string.IsNullOrWhiteSpace(hoTen)) return false;
            hoTen = hoTen.Trim();
            var pattern = @"^(?!.*  )(?!\s)(?!.*\s$)[A-ZÀ-Ỹ][a-zà-ỹ]*(?: [A-ZÀ-Ỹ][a-zà-ỹ]*)*$";
            return Regex.IsMatch(hoTen, pattern);
        }

        public string ChuanHoaHoTen(string hoTen)
        {
            return string.Join(" ",
                hoTen.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }

        public bool IsValidSoDienThoai(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return false;
            sdt = sdt.Trim();
            var pattern = @"^(09|08|03)\d{8}$";
            return Regex.IsMatch(sdt, pattern);
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            email = email.Trim();
            if (email.Length > 90 || !email.EndsWith("@gmail.com")) return false;
            var pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        public bool IsValidTrangThai(string trangThai)
        {
            if (string.IsNullOrWhiteSpace(trangThai)) return false;
            trangThai = trangThai.Trim();
            if (trangThai.Length > 250 || trangThai.Contains("  ")) return false;
            var pattern = @"^[a-zA-Z0-9À-ỹ\s]+$";
            return Regex.IsMatch(trangThai, pattern);
        }

        // --------------------------
        // THÊM HỌC VIÊN (có kiểm tra)
        // --------------------------
        public bool Them(HocVien hv)
        {
            if (!IsValidMaHocVien(hv.MaHocVien) ||
                !IsValidHoTen(hv.HoTen) ||
                !IsValidSoDienThoai(hv.SoDienThoai) ||
                !IsValidEmail(hv.Email) ||
                !IsValidTrangThai(hv.TrangThai)
                )
                return false;

            dal_HocVien.Them(hv);
            return true;
        }

        public void Sua(HocVien hv) => dal_HocVien.CapNhat(hv);
        public void Xoa(string hv) => dal_HocVien.Xoa(hv);
    }
}
