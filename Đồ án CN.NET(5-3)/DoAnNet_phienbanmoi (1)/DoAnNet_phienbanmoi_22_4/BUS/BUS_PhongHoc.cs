using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_PhongHoc
    {
        //
        DAL_PhongHoc dal_phonghoc = new DAL_PhongHoc();
        //lay du lieu
        public List<DAO_PhongHoc> getALlPhongHoc() => dal_phonghoc.GetAllPhongHoc();
        //lấy mã cơ sở 
        public List<string> getAllMaCoSo() => dal_phonghoc.GetAllMaCoSo();
        //theme
        public void Them(PhongHoc ph) => dal_phonghoc.Them(ph);

        //cập nhật
        public void CapNhat(PhongHoc ph) => dal_phonghoc.CapNhat(ph);
        //xoá
        public void Xoa(string ph) => dal_phonghoc.Xoa(ph);
    }
}
