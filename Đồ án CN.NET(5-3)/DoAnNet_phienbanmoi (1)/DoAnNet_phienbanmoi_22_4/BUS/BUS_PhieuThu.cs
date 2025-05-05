using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_PhieuThu
    {
        //
        DAL_PhieuThu dal_phieuthu = new DAL_PhieuThu();
        //
        public List<DAO_PhieuThu> getAllPhieuThu() => dal_phieuthu.GetAllPhieuThu();

        //lấy mã học viên
        public List<string> getAllMaHocVien() => dal_phieuthu.GetAllMaHocVien();
        //thêm 
        public void Them(PhieuThu pt) => dal_phieuthu.Them(pt);

        //cập nhật
        public void CapNhat(PhieuThu pt) => dal_phieuthu.CapNhat(pt);

        //xoá
        public void Xoa(string pt) => dal_phieuthu.Xoa(pt);
    }
}
