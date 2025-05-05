using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_ThemTaiKhoan
    {
        //ket noi database
        QLTTANDataContext db = new QLTTANDataContext();

        //lấy dữ liệu tài khoản
        public List<DAO.DAO_ThemTaiKhoan> GetAllTaiKhoan()
        {
            return db.TaiKhoans
                     .ToList()
                     .Select(tk => new DAO.DAO_ThemTaiKhoan
                     {
                         TenTK = tk.TenTK,
                         MatKhau = tk.MatKhau
                     }).ToList();
        }

        //thêm tài khoản
        public void Them(TaiKhoan themTK)
        {
            db.TaiKhoans.InsertOnSubmit(themTK);
            db.SubmitChanges();
        }
        //cập nhật tài khoản
        public void CapNhat(TaiKhoan tk)
        {
            var capnhat = db.TaiKhoans.FirstOrDefault(x => x.TenTK == tk.TenTK);
            if (capnhat != null)
            {
                capnhat.TenTK = tk.TenTK;
                capnhat.MatKhau = tk.MatKhau;
                db.SubmitChanges();
            }
        }
        //xoá tài khoản
        public void Xoa(string TenTK)
        {
            var tk = db.TaiKhoans.FirstOrDefault(x => x.TenTK == TenTK);
            if (tk != null)
            {
                db.TaiKhoans.DeleteOnSubmit(tk);
                db.SubmitChanges();
            }
        }
    }
}
