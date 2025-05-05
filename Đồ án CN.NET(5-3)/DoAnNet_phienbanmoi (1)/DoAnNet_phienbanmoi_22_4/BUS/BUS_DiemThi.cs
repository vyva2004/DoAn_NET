using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_DiemThi
    {
        DAL_DiemThi daldt = new DAL_DiemThi();
        public IQueryable HienThi()
        {
            return daldt.Hienthi();
        }
        public IQueryable HienThiHV()
        {
            return daldt.HienthiHV();
        }
        public IQueryable HienThiKH()
        {
            return daldt.HienthiKH();
        }
        public void themDT(DAO_DiemThi daodt)
        {
            if (daldt.ThemDT(daodt) == true)
            {
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaDT(string maDT)
        {
            if (daldt.XoaDT(maDT) == true)
            {
                MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CapnhatDT(DAO_DiemThi daodt)
        {
            if (daldt.CapnhatDT(daodt) == true)
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
