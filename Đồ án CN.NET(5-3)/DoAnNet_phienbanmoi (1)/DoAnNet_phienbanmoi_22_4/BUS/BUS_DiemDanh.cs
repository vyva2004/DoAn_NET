using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_DiemDanh
    {
        //
        DAL_DiemDanh DAL_DiemDanh = new DAL_DiemDanh();
        //lấy hết danh sách điểm danh
        public List<DAO_DiemDanh> getALlDiemDanh => DAL_DiemDanh.GetAllDiemDanh();
        //lấy mã giáo viên
        public List<string> getAllMaGiaoVien => DAL_DiemDanh.getAllMaGiaoVien();
        //lấy mã học viên
        public List<string> getAllMaHocVien => DAL_DiemDanh.getAllMaHocVien();

        //thêm 
        public void Them(DiemDanh dd) => DAL_DiemDanh.Them(dd);
        //cập nhật
        public void CapNhat(DiemDanh dd) => DAL_DiemDanh.CapNhat(dd);
        //xoá
        public void Xoa(string dd) => DAL_DiemDanh.Xoa(dd);
    }
}
