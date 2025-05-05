using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_ChucVu
    {
        //ket noi db
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu bảng chức vụ
        public List<DAO.DAO_ChucVu> GetAllChucVu()
        {
            return db.ChucVus
        .ToList() // lấy dữ liệu trước
        .Select(cv => new DAO.DAO_ChucVu
        {
            MaChucVu = cv.MaChucVu,
            TenChucVu = cv.TenChucVu,
        }).ToList();
        }
        //thêm
        public void Them(ChucVu cv)
        {
            db.ChucVus.InsertOnSubmit(cv);
            db.SubmitChanges();
        }
        //cập nhật
        public void CapNhat(ChucVu cv)
        {
            var capnhat = db.ChucVus.FirstOrDefault(x => x.MaChucVu == cv.MaChucVu);
            if (capnhat != null)
            {
                capnhat.MaChucVu = cv.MaChucVu;
                capnhat.TenChucVu = cv.TenChucVu;
                db.SubmitChanges();
            }
        }
        //xoá
        public void Xoa(string maCV)
        {
            var cv = db.ChucVus.FirstOrDefault(x => x.MaChucVu == maCV);
            if (cv != null)
            {
                db.ChucVus.DeleteOnSubmit(cv);
                db.SubmitChanges();
            }
        }
    }
}
