using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiamGia
    {
        QLTTANDataContext db = new QLTTANDataContext();
        public IQueryable Hienthi()
        {
            IQueryable GG = (from gg in db.MaGiamGias
                             select new { gg.MaGiamGia1, gg.TenMaGiamGia, gg.SoTienDuocGiam, gg.HanSuDung, gg.GhiChu });
            return GG;
        }
        public bool ThemGG(DAO_GiamGia daogg)
        {
            if (db.MaGiamGias.Any(sp => sp.MaGiamGia1 == daogg.MaGiamGia))
            {
                return false;
            }
            try
            {
                MaGiamGia gg = new MaGiamGia
                {
                    MaGiamGia1 = daogg.MaGiamGia,
                    TenMaGiamGia = daogg.TenGiamGia,
                    SoTienDuocGiam = daogg.SoTienDuocGiam,
                    HanSuDung = daogg.Hansudung,
                    GhiChu = daogg.Ghichu,
                };
                db.MaGiamGias.InsertOnSubmit(gg);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        public bool XoaGG(string maGG)
        {
            try
            {
                var xoa = from gg in db.MaGiamGias
                          where gg.MaGiamGia1 == maGG
                          select gg;
                foreach (var x in xoa)
                {
                    db.MaGiamGias.DeleteOnSubmit(x);
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
        public bool CapnhatGG(DAO_GiamGia daogg)
        {
            try
            {
                var update = db.MaGiamGias.Single(sp => sp.MaGiamGia1 == daogg.MaGiamGia);
                update.TenMaGiamGia = daogg.TenGiamGia;
                update.SoTienDuocGiam = daogg.SoTienDuocGiam;
                update.HanSuDung = daogg.Hansudung;
                update.GhiChu = daogg.Ghichu;
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
