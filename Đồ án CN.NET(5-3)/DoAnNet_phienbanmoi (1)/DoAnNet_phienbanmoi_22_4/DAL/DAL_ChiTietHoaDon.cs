using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_ChiTietHoaDon
    {
        //ket noi db
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu bảng chi tiết hóa đơn
        public List<DAO.DAO_ChiTietHoaDon> GetAllChiTietHoaDon()
        {
            return db.HoaDonChiTiets
        .ToList() // lấy dữ liệu trước
        .Select(hdct => new DAO.DAO_ChiTietHoaDon
        {
            MaHoaDonChiTiet = hdct.MaHoaDonChiTiet,
            MaHoaDon = hdct.MaHoaDon,
            MaKhoaHoc = hdct.MaKhoaHoc,
            SoTien = (float)hdct.SoTien,
            GhiChu = hdct.GhiChu
        }).ToList();
        }

        //lấy dữ liệu mã hóa đơn
        public List<string> getAllMaHoaDon()
        {
            return db.HoaDons.Select(hd => hd.MaHoaDon).ToList();
        }

        //lấy dữ liệu bảng khóa học
        public List<string> getAllKhoaHoc()
        {
            return db.KhoaHocs.Select(kh => kh.MaKhoaHoc).ToList();
        }
        //xóa
        public void Xoa(string maHDCT)
        {
            var hdct = db.HoaDonChiTiets.FirstOrDefault(x => x.MaHoaDonChiTiet == maHDCT);
            if (hdct != null)
            {
                db.HoaDonChiTiets.DeleteOnSubmit(hdct);
                db.SubmitChanges();
            }
        }

        //cập nhật
        public void CapNhat(HoaDonChiTiet hdct)
        {
            var capnhat = db.HoaDonChiTiets.FirstOrDefault(x => x.MaHoaDonChiTiet == hdct.MaHoaDonChiTiet);
            if (capnhat != null)
            {
                capnhat.MaHoaDonChiTiet = hdct.MaHoaDonChiTiet;
                capnhat.MaHoaDon = hdct.MaHoaDon;
                capnhat.KhoaHoc = hdct.KhoaHoc;
                capnhat.SoTien = hdct.SoTien;
                capnhat.GhiChu = hdct.GhiChu;
                db.SubmitChanges();
            }
        }
    }
}
