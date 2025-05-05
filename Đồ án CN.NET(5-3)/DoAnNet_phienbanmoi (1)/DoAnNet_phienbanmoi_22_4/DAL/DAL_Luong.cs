using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Luong
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable Hienthi()
        {
            IQueryable L = (from l in db.Luongs
                             select new { l.MaLuong, l.MaGiaoVien, l.NgayTra, l.SoTienLuong, l.GhiChu,l.SoGioLamViec });
            return L;
        }
        public IQueryable HienthiGV()
        {
            IQueryable GV = (from gv in db.GiaoViens
                            select new { gv.MaGiaoVien, gv.HoTen });
            return GV;
        }
        public bool ThemLuong(DAO_Luong daoluong)
        {
            if (db.Luongs.Any(sp => sp.MaLuong == daoluong.Maluong))
            {
                return false;
            }
            try
            {
                Luong l = new Luong
                {
                    MaLuong = daoluong.Maluong,
                    MaGiaoVien = daoluong.MaGV,
                    NgayTra = daoluong.Ngaytra,
                    SoTienLuong = daoluong.Sotienluong,
                    GhiChu = daoluong.Ghichu,
                    SoGioLamViec = daoluong.Giolamviec,
                };
                db.Luongs.InsertOnSubmit(l);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaLuong(string maLuong)
        {
            try
            {
                var xoa = from l in db.Luongs
                          where l.MaLuong == maLuong
                          select l;
                foreach (var x in xoa)
                {
                    db.Luongs.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                return false;
            }
        }
        public bool CapnhatLuong(DAO_Luong daoluong)
        {
            try
            {
                var update = db.Luongs.Single(sp => sp.MaLuong == daoluong.Maluong);
                update.MaGiaoVien = daoluong.MaGV;
                update.NgayTra = daoluong.Ngaytra;
                update.SoTienLuong = daoluong.Sotienluong;
                update.GhiChu = daoluong.Ghichu;
                update.SoGioLamViec = daoluong.Giolamviec;
                db.SubmitChanges();
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
    }
    

}
