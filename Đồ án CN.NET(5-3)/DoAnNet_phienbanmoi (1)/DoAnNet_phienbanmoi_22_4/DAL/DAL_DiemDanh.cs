using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_DiemDanh
    {
        //ket noi db
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu bảng điểm danh
        public List<DAO.DAO_DiemDanh> GetAllDiemDanh()
        {
            return db.DiemDanhs
        .ToList() // lấy dữ liệu trước
        .Select(dd => new DAO.DAO_DiemDanh
        {
            MaDiemDanh = dd.MaDiemDanh,
            MaGiaoVien = dd.MaGiaoVien,
            TenGiaoVien = dd.TenGiaoVien,
            MaHocVien = dd.MaHocVien,
            NgayHoc = (DateTime)dd.NgayHoc,
            TrangThai = dd.TrangThai
        }).ToList();
        }

        // lấy dữ liệu Mã học viên
        public List<string> getAllMaHocVien()
        {
            return db.HocViens.Select(c => c.MaHocVien).ToList();
        }
        //lấy dữ liệu mã giáo viên
        public List<string> getAllMaGiaoVien()
        {
            return db.GiaoViens.Select(c => c.MaGiaoVien).ToList();
        }
        //thêm điểm danh
        public void Them(DiemDanh dd)
        {
            db.DiemDanhs.InsertOnSubmit(dd);
            db.SubmitChanges();
        }
        //cập nhật điểm danh
        public void CapNhat(DiemDanh dd)
        {
            var capnhat = db.DiemDanhs.FirstOrDefault(x => x.MaDiemDanh == dd.MaDiemDanh);
            if (capnhat != null)
            {
                capnhat.MaDiemDanh = dd.MaDiemDanh;
                capnhat.MaGiaoVien = dd.MaGiaoVien;
                capnhat.TenGiaoVien = dd.TenGiaoVien;
                capnhat.MaHocVien = dd.MaHocVien;
                capnhat.NgayHoc = dd.NgayHoc;
                capnhat.TrangThai = dd.TrangThai;
                db.SubmitChanges();
            }
        }
        //xoá điểm danh
        public void Xoa(string maDD)
        {
            var dd = db.DiemDanhs.FirstOrDefault(x => x.MaDiemDanh == maDD);
            if (dd != null)
            {
                db.DiemDanhs.DeleteOnSubmit(dd);
                db.SubmitChanges();
            }
        }
    }
}
