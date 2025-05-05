using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_LichHoc
    {

        DAL_LichHoc dal_lichhoc = new DAL_LichHoc();

        public List<DAO_LichHoc> GetAllLichHoc() => dal_lichhoc.GetAllLichHoc();

        //lấy mã lớp học
        public List<string> getAllMaLopHoc() => dal_lichhoc.GetAllMaLopHoc();

        //lấy mã phòng học
        public List<string> getAllMaPhong() => dal_lichhoc.GetAllMaPhong();

        //lấy mã nhân viên
        public List<string> getAllMaGiaoVien() => dal_lichhoc.getAllMaGiaoVien();
        //thêm 
        public void Them(LichHoc lichhoc) => dal_lichhoc.Them(lichhoc);

        //cập nhật
        public void CapNhat(LichHoc lichhoc) => dal_lichhoc.CapNhat(lichhoc);

        //xoá
        public void Xoa(string lichhoc) => dal_lichhoc.Xoa(lichhoc);
    }
}
