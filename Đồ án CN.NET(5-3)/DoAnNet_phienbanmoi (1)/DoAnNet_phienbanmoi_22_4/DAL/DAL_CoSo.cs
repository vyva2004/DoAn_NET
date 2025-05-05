using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CoSo
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable Hienthi()
        {
            IQueryable CS = (from cs in db.CoSos
                             select new { cs.MaCoSo, cs.TenCoSo, cs.DiaChi, cs.SoDienThoai, cs.Email });
            return CS;
        }
        public bool ThemCS(DAO_CoSo daocs)
        {
            if (db.CoSos.Any(sp => sp.MaCoSo == daocs.Macoso))
            {
                return false;
            }
            try
            {
                CoSo cs = new CoSo
                {
                    MaCoSo = daocs.Macoso,
                    TenCoSo = daocs.Tencoso,
                    DiaChi = daocs.Diachi,
                    SoDienThoai = daocs.Sodienthoai,
                    Email = daocs.Email,
                };
                db.CoSos.InsertOnSubmit(cs);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaCS(string maCS)
        {
            try
            {
                var xoa = from cs in db.CoSos
                          where cs.MaCoSo == maCS
                          select cs;
                foreach (var x in xoa)
                {
                    db.CoSos.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                return false;
            }
        }
        public bool CapnhatCS(DAO_CoSo daocs)
        {
            try
            {
                var update = db.CoSos.Single(sp => sp.MaCoSo == daocs.Macoso);
                update.TenCoSo = daocs.Tencoso;
                update.DiaChi = daocs.Diachi;
                update.SoDienThoai = daocs.Sodienthoai;
                update.Email = daocs.Email;
                db.SubmitChanges();
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
    }
}
