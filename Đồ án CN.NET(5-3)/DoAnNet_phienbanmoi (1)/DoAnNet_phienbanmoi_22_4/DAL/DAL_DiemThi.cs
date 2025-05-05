using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DiemThi
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable Hienthi()
        {
            IQueryable DT = (from dt in db.DiemThis
                             select new { dt.MaDiemThi, dt.MaHocVien, dt.MaKhoaHoc, dt.Diem, dt.NgayThi });
            return DT;
        }
        public IQueryable HienthiHV()
        {
            IQueryable HV = (from hv in db.HocViens
                             select new { hv.MaHocVien, hv.HoTen });
            return HV;
        }
        public IQueryable HienthiKH()
        {
            IQueryable KH = (from kh in db.KhoaHocs
                             select new { kh.MaKhoaHoc, kh.TenKhoaHoc });
            return KH;
        }
        public bool ThemDT(DAO_DiemThi daodt)
        {
            if (db.DiemThis.Any(sp => sp.MaDiemThi == daodt.Madiemthi))
            {
                return false;
            }
            try
            {
                DiemThi dt = new DiemThi
                {
                    MaDiemThi = daodt.Madiemthi,
                    MaHocVien = daodt.Mahocvien,
                    MaKhoaHoc = daodt.Makhoahoc,
                    Diem = daodt.Diem,
                    NgayThi = daodt.Ngaythi,
                };
                db.DiemThis.InsertOnSubmit(dt);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaDT(string maDT)
        {
            try
            {
                var xoa = from dt in db.DiemThis
                          where dt.MaDiemThi == maDT
                          select dt;
                foreach (var x in xoa)
                {
                    db.DiemThis.DeleteOnSubmit(x);
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
        public bool CapnhatDT(DAO_DiemThi daodt)
        {
            try
            {
                var update = db.DiemThis.Single(sp => sp.MaDiemThi == daodt.Madiemthi);
                update.MaHocVien = daodt.Mahocvien;
                update.MaKhoaHoc = daodt.Makhoahoc;
                update.Diem = daodt.Diem;
                update.NgayThi = daodt.Ngaythi;
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
