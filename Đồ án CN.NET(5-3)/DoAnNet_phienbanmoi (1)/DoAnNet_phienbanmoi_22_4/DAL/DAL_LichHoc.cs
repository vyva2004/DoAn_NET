using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_LichHoc
    {
        //ket noi database
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu lịch học
        public List<DAO.DAO_LichHoc> GetAllLichHoc()
        {
            return db.LichHocs
                     .ToList()
                     .Select(lh => new DAO.DAO_LichHoc
                     {
                         MaLichHoc = lh.MaLichHoc,
                         MaLopHoc = lh.MaLopHoc,
                         NgayHoc = (DateTime)lh.NgayHoc,
                         CaHoc = lh.CaHoc,
                         MaPhong = lh.MaPhong,
                         MaGiaoVien = lh.MaGiaoVien
                     }).ToList();
        }

        //lấy mã lớp học
        public List<string> GetAllMaLopHoc()
        {
            return db.LopHocs.Select(l => l.MaLopHoc).ToList();
        }

        //lấy mã phòng
        public List<string> GetAllMaPhong()
        {
            return db.PhongHocs.Select(ph => ph.MaPhong).ToList();
        }
        //lấy mã nhân viên
        public List<string> getAllMaGiaoVien()
        {
            return db.GiaoViens.Select(nv => nv.MaGiaoVien).ToList();
        }
        //thêm Lịch học
        public void Them(LichHoc lh)
        {
            db.LichHocs.InsertOnSubmit(lh);
            db.SubmitChanges();
        }

        //cập nhật Lịch học
        public void CapNhat(LichHoc lh)
        {
            var capnhat = db.LichHocs.FirstOrDefault(x => x.MaLichHoc == lh.MaLichHoc);
            if (capnhat != null)
            {
                capnhat.MaLichHoc = lh.MaLichHoc;
                capnhat.MaLopHoc = lh.MaLopHoc;
                capnhat.NgayHoc = lh.NgayHoc;
                capnhat.CaHoc = lh.CaHoc;
                capnhat.MaPhong = lh.MaPhong;
                capnhat.MaGiaoVien = lh.MaGiaoVien;
                db.SubmitChanges();
            }
        }
        //xoá Lịch học
        public void Xoa(string MaLichHoc)
        {
            var lh = db.LichHocs.FirstOrDefault(x => x.MaLichHoc == MaLichHoc);
            if (lh != null)
            {
                db.LichHocs.DeleteOnSubmit(lh);
                db.SubmitChanges();
            }
        }
    }
}
