using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Luong
    {
        DAL_Luong dalluong = new DAL_Luong();
        public IQueryable HienThi()
        {
            return dalluong.Hienthi();
        }
        public IQueryable HienThiGV()
        {
            return dalluong.HienthiGV();
        }
        public void themLuong(DAO_Luong daoluong)
        {
            if (dalluong.ThemLuong(daoluong) == true)
            {
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaLuong(string maLuong)
        {
            if (dalluong.XoaLuong(maLuong) == true)
            {
                MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CapnhatLuong(DAO_Luong daoluong)
        {
            if (dalluong.CapnhatLuong(daoluong) == true)
            {
                MessageBox.Show("Cập nhật thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
