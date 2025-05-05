using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_HoaDon
    {
        //kết nối database 
        QLTTANDataContext db = new QLTTANDataContext();


        //lấy dữ liệu trong bảng hoá đơn
        public List<DAO.DAO_HoaDon> GetAll()
        {
            return db.HoaDons
        .ToList() // lấy dữ liệu trước
        .Select(h => new DAO.DAO_HoaDon
        {
            MaHoaDon = h.MaHoaDon,
            MaHocVien = h.MaHocVien,
            NgayLapHoaDon = (DateTime)h.NgayLapHoaDon,
            TongTien = (float)h.TongTien,
            MaGiamGia = h.MaGiamGia
        }).ToList();
        }

        //thêm hoá đơn
        public void Them(HoaDon hd)
        {
            db.HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
        }

        //cập nhật hoá đơn
        public void CapNhat(HoaDon hd)
        {
            var capnhat = db.HoaDons.FirstOrDefault(x => x.MaHoaDon == hd.MaHoaDon);
            if (capnhat != null)
            {
                capnhat.MaHocVien = hd.MaHocVien;
                capnhat.NgayLapHoaDon = hd.NgayLapHoaDon;
                capnhat.TongTien = hd.TongTien;
                capnhat.MaGiamGia = hd.MaGiamGia;
                db.SubmitChanges();
            }
        }

        //xoá hoá đơn
        public void Xoa(string maHD)
        {
            var hd = db.HoaDons.FirstOrDefault(x => x.MaHoaDon == maHD);
            if (hd != null)
            {
                db.HoaDons.DeleteOnSubmit(hd);
                db.SubmitChanges();
            }
        }
    }
}
