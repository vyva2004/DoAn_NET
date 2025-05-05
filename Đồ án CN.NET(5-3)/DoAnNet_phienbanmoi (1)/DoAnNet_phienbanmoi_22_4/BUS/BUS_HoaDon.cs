using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_HoaDon
    {
        //kết nối bảng hoá đơn
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();

        //
        public List<DAO_HoaDon> GetAll() => dal_HoaDon.GetAll();

        //thêm 
        public void Them(HoaDon hd) => dal_HoaDon.Them(hd);

        //cập nhật
        public void CapNhat(HoaDon hd) => dal_HoaDon.CapNhat(hd);

        //xoá
        public void Xoa(string maHD) => dal_HoaDon.Xoa(maHD);
    }
}
