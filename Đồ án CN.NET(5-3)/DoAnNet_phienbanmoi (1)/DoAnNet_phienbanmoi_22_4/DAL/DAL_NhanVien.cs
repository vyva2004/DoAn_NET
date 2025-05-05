using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable HienThiNV()
        {
            IQueryable NV = (from nv in db.NhanViens
                             select new { nv.MaNhanVien, nv.HoTen, nv.MaChucVu, nv.GioiTinh, nv.SoDienThoai, nv.Email, nv.GhiChu, nv.MaCoSo });
            return NV;
        }
        public bool ThemNV(DAO_NhanVien daonv)
        {
            if (db.NhanViens.Any(sp => sp.MaNhanVien == daonv.MaNV))
            {
                return false;
            }
            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = daonv.MaNV,
                    HoTen = daonv.Hoten,
                    MaChucVu = daonv.MaCV,
                    GioiTinh = daonv.Gioitinh,
                    SoDienThoai = daonv.SoDienthoai,
                    Email = daonv.Email,
                    GhiChu = daonv.Ghichu,
                    MaCoSo = daonv.Macoso,
                };
                db.NhanViens.InsertOnSubmit(nv);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaNV(string maNV)
        {
            try
            {
                var xoa = from nv in db.NhanViens
                          where nv.MaNhanVien == maNV
                          select nv;
                foreach (var x in xoa)
                {
                    db.NhanViens.DeleteOnSubmit(x);
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
        public bool CapnhatNV(DAO_NhanVien daonv)
        {
            try
            {
                var update = db.NhanViens.Single(sp => sp.MaNhanVien == daonv.MaNV);
                update.HoTen = daonv.Hoten;
                update.MaChucVu = daonv.MaCV;
                update.GioiTinh = daonv.Gioitinh;
                update.SoDienThoai = daonv.SoDienthoai;
                update.Email = daonv.Email;
                update.GhiChu = daonv.Ghichu;
                update.MaCoSo = daonv.Macoso;
                db.SubmitChanges();
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public IQueryable HienThiChucVu()
        {
            IQueryable CV = from cv in db.ChucVus
                            select new { cv.MaChucVu, cv.TenChucVu };
            return CV;
        }
        public IQueryable Hienthi()
        {
            IQueryable CS = (from cs in db.CoSos
                             select new { cs.MaCoSo, cs.TenCoSo, cs.DiaChi, cs.SoDienThoai, cs.Email });
            return CS;
        }
    }
}

