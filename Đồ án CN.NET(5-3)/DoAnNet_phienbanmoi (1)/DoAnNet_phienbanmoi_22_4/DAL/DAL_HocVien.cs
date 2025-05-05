using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_HocVien
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public List<DAO.DAO_HocVien> GetAllMaHocVien()
        {
            return db.HocViens
        .ToList() // lấy dữ liệu trước
        .Select(h => new DAO.DAO_HocVien
        {

            MaHocVien = h.MaHocVien,
            HoTen = h.HoTen,
            NgaySinh = (DateTime)h.NgaySinh,
            SoDienThoai = h.SoDienThoai,
            email = h.Email,
            TrangThai = h.TrangThai,
            MaCoSo = h.MaCoSo
        }).ToList();
        }

        //lấy danh sách mã cơ sở
        public List<string> GetAllMaCoSo()
        {
            return db.CoSos.Select(c => c.MaCoSo).ToList();
        }

        //thêm học viên
        public void Them(HocVien hv)
        {
            db.HocViens.InsertOnSubmit(hv);
            db.SubmitChanges();
        }

        //cập nhật học viên
        public void CapNhat(HocVien hv)
        {
            var capnhat = db.HocViens.FirstOrDefault(x => x.MaHocVien == hv.MaHocVien);
            if (capnhat != null)
            {
                capnhat.MaHocVien = hv.MaHocVien;
                capnhat.HoTen = hv.HoTen;
                capnhat.NgaySinh = hv.NgaySinh;
                capnhat.SoDienThoai = hv.SoDienThoai;
                capnhat.Email = hv.Email;
                capnhat.TrangThai = hv.TrangThai;
                capnhat.MaCoSo = hv.MaCoSo;
                db.SubmitChanges();
            }
        }
        //xoá học viên
        public void Xoa(string MaHV)
        {
            var hv = db.HocViens.FirstOrDefault(x => x.MaHocVien == MaHV);
            if (hv != null)
            {
                db.HocViens.DeleteOnSubmit(hv);
                db.SubmitChanges();
            }
        }

    }
}
