using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_NhanVien
    {
        private string _MaNV;
        private string _Hoten;
        private string _MaCV;
        private string _Gioitinh;
        private string _SoDienthoai;
        private string _Email;
        private string _Ghichu;
        private string _Macoso;



        public DAO_NhanVien(string maNV, string hoten, string maCV, string gioitinh, string soDienthoai, string email, string ghichu, string macoso)
        {
            _MaNV = maNV;
            _Hoten = hoten;
            _MaCV = maCV;
            _Gioitinh = gioitinh;
            _SoDienthoai = soDienthoai;
            _Email = email;
            _Ghichu = ghichu;
            _Macoso = macoso;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string Hoten { get => _Hoten; set => _Hoten = value; }
        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public string Gioitinh { get => _Gioitinh; set => _Gioitinh = value; }
        public string SoDienthoai { get => _SoDienthoai; set => _SoDienthoai = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Ghichu { get => _Ghichu; set => _Ghichu = value; }
        public string Macoso { get => _Macoso; set => _Macoso = value; }
        public DAO_NhanVien() { }
    }
}
