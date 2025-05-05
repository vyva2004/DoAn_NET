using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAL
{
    public class DAL_GiaoVien
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public List<DAO_GiaoVien> GetAllGiaoVien()
        {
            return db.GiaoViens.Select(gv => new DAO.DAO_GiaoVien
            {
                MaGiaoVien = gv.MaGiaoVien,
                HoTenGiaoVien = gv.HoTen,
                GioiTinh = gv.Gioitinh,
                NgaySinh = (DateTime)gv.Ngaysinh,
                SoDienThoai = gv.SoDienThoai,
                Email = gv.Email,
                MaCoSo = gv.MaCoSo,
                GhiChu = gv.GhiChu
            }).ToList();
        }

        //lấy danh sách mã cơ sở
        public List<string> GetAllMaCoSo()
        {
            return db.CoSos.Select(c => c.MaCoSo).ToList();
        }

        //thêm học viên
        public void Them(DAL.GiaoVien gv)
        {
            db.GiaoViens.InsertOnSubmit(gv);
            db.SubmitChanges();
        }


        public void CapNhat(DAL.GiaoVien gv)
        {
            var capnhat = db.GiaoViens.FirstOrDefault(x => x.MaGiaoVien == gv.MaGiaoVien);
            if (capnhat != null)
            {
                capnhat.MaGiaoVien = gv.MaGiaoVien;
                capnhat.HoTen = gv.HoTen;
                capnhat.Gioitinh = gv.Gioitinh;
                capnhat.Ngaysinh = gv.Ngaysinh;
                capnhat.SoDienThoai = gv.SoDienThoai;
                capnhat.Email = gv.Email;
                capnhat.MaCoSo = gv.MaCoSo;
                capnhat.GhiChu = gv.GhiChu;
                db.SubmitChanges();
            }
        }
        //xoá học viên
        public void Xoa(string MaGV)
        {
            var gv = db.GiaoViens.FirstOrDefault(x => x.MaGiaoVien == MaGV);
            if (gv != null)
            {
                db.GiaoViens.DeleteOnSubmit(gv);
                db.SubmitChanges();
            }
        }
    }
}
