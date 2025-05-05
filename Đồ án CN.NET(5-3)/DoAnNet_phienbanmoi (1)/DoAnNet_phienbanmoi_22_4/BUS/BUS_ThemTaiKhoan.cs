using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_ThemTaiKhoan
    {
        DAL_ThemTaiKhoan dal_taikhoan = new DAL_ThemTaiKhoan();

        public List<DAO_ThemTaiKhoan> getAllTaiKhoan() => dal_taikhoan.GetAllTaiKhoan();

        //thêm 
        public void Them(TaiKhoan tk) => dal_taikhoan.Them(tk);

        //cập nhật
        public void CapNhat(TaiKhoan tk) => dal_taikhoan.CapNhat(tk);

        //xoá
        public void Xoa(string tk) => dal_taikhoan.Xoa(tk);
    }
}
