using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUS
{
    public class BUS_ChucVu
    {
        //
        DAL_ChucVu DAL_ChucVu = new DAL_ChucVu();
        //lấy danh sách chức vụ
        public List<DAO.DAO_ChucVu> getAllChucVu() => DAL_ChucVu.GetAllChucVu();

        //thêm chức vụ
        public void Them(ChucVu cv) => DAL_ChucVu.Them(cv);
        //cập nhật chức vụ
        public void CapNhat(ChucVu cv) => DAL_ChucVu.CapNhat(cv);

        //xóa chức vụ
        public void Xoa(string MaCV) => DAL_ChucVu.Xoa(MaCV);
    }
}
