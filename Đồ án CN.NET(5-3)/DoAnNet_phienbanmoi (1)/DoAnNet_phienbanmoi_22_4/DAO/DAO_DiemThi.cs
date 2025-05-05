using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_DiemThi
    {
        private string _Madiemthi;
        private string _Mahocvien;
        private string _Makhoahoc;
        private double _Diem;
        private DateTime _ngaythi;

        public DAO_DiemThi(string madiemthi, string mahocvien, string makhoahoc, double diem, DateTime ngaythi)
        {
            _Madiemthi = madiemthi;
            _Mahocvien = mahocvien;
            _Makhoahoc = makhoahoc;
            _Diem = diem;
            _ngaythi = ngaythi;
        }

        public string Madiemthi { get => _Madiemthi; set => _Madiemthi = value; }
        public string Mahocvien { get => _Mahocvien; set => _Mahocvien = value; }
        public string Makhoahoc { get => _Makhoahoc; set => _Makhoahoc = value; }
        public double Diem { get => _Diem; set => _Diem = value; }
        public DateTime Ngaythi { get => _ngaythi; set => _ngaythi = value; }
        public DAO_DiemThi() { }
    }
}
