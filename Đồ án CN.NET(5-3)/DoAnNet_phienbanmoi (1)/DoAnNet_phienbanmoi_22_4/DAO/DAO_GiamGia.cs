using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_GiamGia
    {
        private string _MaGiamGia;
        private string _TenGiamGia;
        private double _SoTienDuocGiam;
        private DateTime _Hansudung;
        private string _Ghichu;

        public DAO_GiamGia(string maGiamGia, string tenGiamGia, double soTienDuocGiam, DateTime hansudung, string ghichu)
        {
            _MaGiamGia = maGiamGia;
            _TenGiamGia = tenGiamGia;
            _SoTienDuocGiam = soTienDuocGiam;
            _Hansudung = hansudung;
            _Ghichu = ghichu;
        }

        public string MaGiamGia { get => _MaGiamGia; set => _MaGiamGia = value; }
        public string TenGiamGia { get => _TenGiamGia; set => _TenGiamGia = value; }
        public double SoTienDuocGiam { get => _SoTienDuocGiam; set => _SoTienDuocGiam = value; }
        public DateTime Hansudung { get => _Hansudung; set => _Hansudung = value; }
        public string Ghichu { get => _Ghichu; set => _Ghichu = value; }
        public DAO_GiamGia() { }
    }
}
