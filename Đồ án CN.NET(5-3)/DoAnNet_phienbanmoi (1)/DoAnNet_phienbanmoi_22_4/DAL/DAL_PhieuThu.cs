using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_PhieuThu
    {
        //ket noi database
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu phiếu thu
        public List<DAO.DAO_PhieuThu> GetAllPhieuThu()
        {
            return db.PhieuThus
                     .ToList()
                     .Select(pt => new DAO.DAO_PhieuThu
                     {
                         MaPhieuThu = pt.MaPhieuThu,
                         MaHocVien = pt.MaHocVien,
                         NgayThu = (DateTime)pt.NgayThu,
                         SoTien = (float)pt.SoTien,
                         GhiChu = pt.GhiChu
                         
                     }).ToList();
        }
        //lấy mã học viên
        public List<string> GetAllMaHocVien()
        {
            return db.HocViens.Select(nv => nv.MaHocVien).ToList();
        }
        //thêm phiếu thu
        public void Them(PhieuThu themPT)
        {
            db.PhieuThus.InsertOnSubmit(themPT);
            db.SubmitChanges();
        }

        //cập nhật phiếu thu
        public void CapNhat(PhieuThu pt)
        {
            var capnhat = db.PhieuThus.FirstOrDefault(x => x.MaPhieuThu == pt.MaPhieuThu);
            if (capnhat != null)
            {
                capnhat.MaPhieuThu = pt.MaPhieuThu;
                capnhat.MaHocVien = pt.MaHocVien;
                capnhat.NgayThu = pt.NgayThu;
                capnhat.SoTien = pt.SoTien;
                capnhat.GhiChu = pt.GhiChu;
                db.SubmitChanges();
            }
        }
        //xoá phiếu thu
        public void Xoa(string MaPT)
        {
            var pt = db.PhieuThus.FirstOrDefault(x => x.MaPhieuThu == MaPT);
            if (pt != null)
            {
                db.PhieuThus.DeleteOnSubmit(pt);
                db.SubmitChanges();
            }
        }
    }
}
