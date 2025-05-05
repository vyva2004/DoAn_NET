using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        //
        DAL_ChiTietHoaDon DAL_ChiTietHoaDon = new DAL_ChiTietHoaDon();

        //lấy danh sách chi tiết hóa đơn
        public List<DAO_ChiTietHoaDon> getAllChiTietHoaDon => DAL_ChiTietHoaDon.GetAllChiTietHoaDon();
        //lấy mã hóa đơn
        public List<string> getAllMaHoaDon => DAL_ChiTietHoaDon.getAllMaHoaDon();

        //lấy mã khóa học
        public List<string> getAllMaKhoaHoc => DAL_ChiTietHoaDon.getAllKhoaHoc();

        //cập nhật
        public void CapNhat(HoaDonChiTiet cthd) => DAL_ChiTietHoaDon.CapNhat(cthd);
        //xoá
        public void Xoa(string cthd) => DAL_ChiTietHoaDon.Xoa(cthd);
    }
}
