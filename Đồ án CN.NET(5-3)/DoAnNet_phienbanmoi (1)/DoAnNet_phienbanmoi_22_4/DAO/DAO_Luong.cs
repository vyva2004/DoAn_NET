using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Luong
    {
        private string _Maluong;
        private string _MaGV;
        private DateTime _Ngaytra;
        private int _Sotienluong;
        private string _Ghichu;
        private int _Giolamviec;

        public DAO_Luong(string maluong, string maGV, DateTime ngaytra, int sotienluong, string ghichu, int giolamviec)
        {
            _Maluong = maluong;
            _MaGV = maGV;
            _Ngaytra = ngaytra;
            _Sotienluong = sotienluong;
            _Ghichu = ghichu;
            _Giolamviec = giolamviec;
        }

        public string Maluong { get => _Maluong; set => _Maluong = value; }
        public string MaGV { get => _MaGV; set => _MaGV = value; }
        public DateTime Ngaytra { get => _Ngaytra; set => _Ngaytra = value; }
        public int Sotienluong { get => _Sotienluong; set => _Sotienluong = value; }
        public string Ghichu { get => _Ghichu; set => _Ghichu = value; }
        public int Giolamviec { get => _Giolamviec; set => _Giolamviec = value; }
        public DAO_Luong() { }
    }
}
