using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_PhongHoc
    {
        //ket noi database
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu phòng học
        public List<DAO.DAO_PhongHoc> GetAllPhongHoc()
        {
            return db.PhongHocs
                     .ToList()
                     .Select(phoc => new DAO.DAO_PhongHoc
                     {
                         MaPhong = phoc.MaPhong,
                         TenPhong = phoc.TenPhong,
                         SucChua = (int)phoc.SucChua,
                         MaCoSo = phoc.MaCoSo
                     }).ToList();
        }
        //lấy danh sách mã cơ sở
        public List<string> GetAllMaCoSo()
        {
            return db.CoSos.Select(c => c.MaCoSo).ToList();
        }
        //thêm
        public void Them(PhongHoc themPH)
        {
            db.PhongHocs.InsertOnSubmit(themPH);
            db.SubmitChanges();
        }
        //cập nhật
        public void CapNhat(PhongHoc ph)
        {
            var capnhat = db.PhongHocs.FirstOrDefault(x => x.MaPhong == ph.MaPhong);
            if (capnhat != null)
            {
                capnhat.MaPhong = ph.MaPhong;
                capnhat.TenPhong = ph.TenPhong;
                capnhat.SucChua = ph.SucChua;
                capnhat.MaCoSo = ph.MaCoSo;
                db.SubmitChanges();
            }
        }

        //xoá
        public void Xoa(string MaPH)
        {
            var ph = db.PhongHocs.FirstOrDefault(x => x.MaPhong == MaPH);
            if (ph != null)
            {
                db.PhongHocs.DeleteOnSubmit(ph);
                db.SubmitChanges();
            }
        }
    }
}
