using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_KhoaHoc
    {
        //
        DAL_KhoaHoc dal_khoahoc = new DAL_KhoaHoc();
        //
        public List<DAO_KhoaHoc> getAllKhoaHoc() => dal_khoahoc.GetAllKhoaHoc();
        //thêm 
        public void Them(KhoaHoc kh) => dal_khoahoc.Them(kh);
        //cập nhật
        public void CapNhat(KhoaHoc kh) => dal_khoahoc.CapNhat(kh);
        //xoá
        public void Xoa(string kh) => dal_khoahoc.Xoa(kh);
    }
}
