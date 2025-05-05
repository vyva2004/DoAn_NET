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
    public class BUS_LopHoc
    {
        DAL_LopHoc dallh = new DAL_LopHoc();
        public IQueryable HienThi()
        {
            return dallh.Hienthi();
        }
        public IQueryable HienThiKH()
        {
            return dallh.HienthiKH();
        }
        public IQueryable HienThiCS()
        {
            return dallh.HienthiCS();
        }
        public IQueryable HienThiGV()
        {
            return dallh.HienthiGV();
        }
        public IQueryable HienThiPhong()
        {
            return dallh.HienthiPhong();
        }
        public void ThemLH(DAO_LopHoc daolh)
        {
            if (dallh.ThemLH(daolh) == true)
            {
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaLH(string maLH)
        {
            if (dallh.XoaLH(maLH) == true)
            {
                MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CapnhatLH(DAO_LopHoc daolh)
        {
            if (dallh.CapnhatLH(daolh) == true)
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
