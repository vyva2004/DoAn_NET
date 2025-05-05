using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LopHoc
    {
        private string _Malophoc;
        private string _Tenlophoc;
        private string _Makhoahoc;
        private string _Macoso;
        private string _Magiaovien;
        private DateTime _Ngaybatdau;
        private DateTime _Ngayketthuc;
        private string _Cahoc;
        private string _Maphong;

        public DAO_LopHoc(string malophoc, string tenlophoc, string makhoahoc, string macoso, string magiaovien, DateTime ngaybatdau, DateTime ngayketthuc, string cahoc, string maphong)
        {
            _Malophoc = malophoc;
            _Tenlophoc = tenlophoc;
            _Makhoahoc = makhoahoc;
            _Macoso = macoso;
            _Magiaovien = magiaovien;
            _Ngaybatdau = ngaybatdau;
            _Ngayketthuc = ngayketthuc;
            _Cahoc = cahoc;
            _Maphong = maphong;
        }

        public string Malophoc { get => _Malophoc; set => _Malophoc = value; }
        public string Tenlophoc { get => _Tenlophoc; set => _Tenlophoc = value; }
        public string Makhoahoc { get => _Makhoahoc; set => _Makhoahoc = value; }
        public string Macoso { get => _Macoso; set => _Macoso = value; }
        public string Magiaovien { get => _Magiaovien; set => _Magiaovien = value; }
        public DateTime Ngaybatdau { get => _Ngaybatdau; set => _Ngaybatdau = value; }
        public DateTime Ngayketthuc { get => _Ngayketthuc; set => _Ngayketthuc = value; }
        public string Cahoc { get => _Cahoc; set => _Cahoc = value; }
        public string Maphong { get => _Maphong; set => _Maphong = value; }
        public DAO_LopHoc() { }
    }
}
