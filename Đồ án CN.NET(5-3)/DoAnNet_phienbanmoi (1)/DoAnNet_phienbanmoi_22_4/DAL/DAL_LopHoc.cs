using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LopHoc
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable Hienthi()
        {
            IQueryable LH = (from lh in db.LopHocs
                             select new { lh.MaLopHoc, lh.TenLopHoc, lh.MaKhoaHoc, lh.MaCoSo, lh.MaGiaoVien, lh.NgayBatDau, lh.NgayKetThuc, lh.CaHoc, lh.MaPhong });
            return LH;
        }
        public IQueryable HienthiKH()
        {
            IQueryable KH = (from kh in db.KhoaHocs
                             select new { kh.MaKhoaHoc, kh.TenKhoaHoc });
            return KH;
        }
        public IQueryable HienthiCS()
        {
            IQueryable CS = (from cs in db.CoSos
                             select new { cs.MaCoSo, cs.TenCoSo, cs.DiaChi, cs.SoDienThoai, cs.Email });
            return CS;
        }
        public IQueryable HienthiGV()
        {
            IQueryable GV = (from gv in db.GiaoViens
                             select new { gv.MaGiaoVien, gv.HoTen });
            return GV;
        }
        public IQueryable HienthiPhong()
        {
            IQueryable P = (from p in db.PhongHocs
                            select new { p.MaPhong, p.TenPhong });
            return P;
        }
        public bool ThemLH(DAO_LopHoc daolh)
        {
            if (db.LopHocs.Any(sp => sp.MaLopHoc == daolh.Malophoc))
            {
                return false;
            }
            try
            {
                LopHoc lh = new LopHoc
                {
                    MaLopHoc = daolh.Malophoc,
                    TenLopHoc = daolh.Tenlophoc,
                    MaKhoaHoc = daolh.Makhoahoc,
                    MaCoSo = daolh.Macoso,
                    MaGiaoVien = daolh.Magiaovien,
                    NgayBatDau = daolh.Ngaybatdau,
                    NgayKetThuc = daolh.Ngayketthuc,
                    CaHoc = daolh.Cahoc,
                    MaPhong = daolh.Maphong,
                };
                db.LopHocs.InsertOnSubmit(lh);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaLH(string maLH)
        {
            try
            {
                var xoa = from lh in db.LopHocs
                          where lh.MaLopHoc == maLH
                          select lh;
                foreach (var x in xoa)
                {
                    db.LopHocs.DeleteOnSubmit(x);
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
        public bool CapnhatLH(DAO_LopHoc daolh)
        {
            try
            {
                var update = db.LopHocs.Single(sp => sp.MaLopHoc == daolh.Malophoc);
                update.TenLopHoc = daolh.Tenlophoc;
                update.MaKhoaHoc = daolh.Makhoahoc;
                update.MaCoSo = daolh.Macoso;
                update.MaGiaoVien = daolh.Magiaovien;
                update.NgayBatDau = daolh.Ngaybatdau;
                update.NgayKetThuc = daolh.Ngayketthuc;
                update.CaHoc = daolh.Cahoc;
                update.MaPhong = daolh.Maphong;
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
