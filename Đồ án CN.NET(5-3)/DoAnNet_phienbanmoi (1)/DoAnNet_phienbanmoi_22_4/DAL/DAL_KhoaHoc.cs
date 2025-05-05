using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_KhoaHoc
    {
        //ket noi database
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu khoá học
        public List<DAO.DAO_KhoaHoc> GetAllKhoaHoc()
        {
            return db.KhoaHocs
                     .ToList()
                     .Select(kh => new DAO.DAO_KhoaHoc
                     {
                         MaKhoaHoc = kh.MaKhoaHoc,
                         TenKhoaHoc = kh.TenKhoaHoc,
                         MoTa = kh.MoTa,
                         HocPhi = (float)kh.HocPhi,
                         ThoiGian = kh.ThoiGian
                     }).ToList();
        }

        //thêm khoá học
        public void Them(KhoaHoc kh)
        {
            db.KhoaHocs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        //cập nhật khoá học
        public void CapNhat(KhoaHoc kh)
        {
            var capnhat = db.KhoaHocs.FirstOrDefault(x => x.MaKhoaHoc == kh.MaKhoaHoc);
            if (capnhat != null)
            {
                capnhat.MaKhoaHoc = kh.MaKhoaHoc;
                capnhat.TenKhoaHoc = kh.TenKhoaHoc;
                capnhat.MoTa = kh.MoTa;
                capnhat.HocPhi = kh.HocPhi;
                capnhat.ThoiGian = kh.ThoiGian;
                db.SubmitChanges();
            }
        }
        //xoá khoá học
        public void Xoa(string MaKhoaHoc)
        {
            var kh = db.KhoaHocs.FirstOrDefault(x => x.MaKhoaHoc == MaKhoaHoc);
            if (kh != null)
            {
                db.KhoaHocs.DeleteOnSubmit(kh);
                db.SubmitChanges();
            }
        }
    }
}
