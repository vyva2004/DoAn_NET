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
    public class BUS_GiamGia
    {
        DAL_GiamGia dalgg = new DAL_GiamGia();
        public IQueryable HienThi()
        {
            return dalgg.Hienthi();
        }
        public void themGG(DAO_GiamGia daogg)
        {
            if (dalgg.ThemGG(daogg) == true)
            {
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaGG(string maGG)
        {
            if (dalgg.XoaGG(maGG) == true)
            {
                MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CapnhatGG(DAO_GiamGia daogg)
        {
            if (dalgg.CapnhatGG(daogg) == true)
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
