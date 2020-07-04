using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QLRPWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QLRP" in both code and config file together.
    public class QLRP : IQLRP
    {
        //private PhimDAL phimDal;
        //private NhanVienDAL nhanVienDal;
        //private RapPhimDAL rapPhimDal;
        //private SuatChieuDAL suatChieuDal;
        //private VeDAL veDAL;
        //private HashSupport hashSupport;

        private RapPhimDBContext db;
        private HashSupport hashSupport;

        public QLRP()
        {
            //phimDal = new PhimDAL();
            //nhanVienDal = new NhanVienDAL();
            //rapPhimDal = new RapPhimDAL();
            //suatChieuDal = new SuatChieuDAL();
            //veDAL = new VeDAL();
            //hashSupport = new HashSupport();

            db = new RapPhimDBContext();
            hashSupport = new HashSupport();
        }

        public eNhanVien CreateNhanVien(eNhanVien nv)
        {
            nv.password = hashSupport.Hash(nv.password);
            var result = db.NhanViens.Add(nv);
            db.SaveChanges();
            return result;
        }

        public ePhim CreatePhim(ePhim phim)
        {
            var result = db.Phims.Add(phim);
            db.SaveChanges();
            return result;
        }

        public eVe CreateVe(eVe ve)
        {
            var result = db.Ves.Add(ve);
            db.SaveChanges();
            return result;
        }

        public eNhanVien DangNhap(int id, string password)
        {
            var user = db.NhanViens.FirstOrDefault(x => x.idNhanVien.Equals(id));
            if (user == null)
                return null;
            else if (hashSupport.Verify(password, user.password))
                return user;
            return null;
        }

        public ePhim GetPhimById(int id)
        {
            return db.Phims.FirstOrDefault(x => x.idPhim.Equals(id));
        }

        public List<ePhim> GetPhimConChieu()
        {
            return db.Phims.Where(x => x.ngayDongPhim.CompareTo(DateTime.Now) > 0).ToList();
        }

        public eRapPhim GetRapPhimById(int id)
        {
            return db.RapPhims.FirstOrDefault(x => x.idRapPhim.Equals(id));
        }

        public eVe GetVe(int idVe)
        {
            return db.Ves.FirstOrDefault(x => x.idVe.Equals(idVe));
        }

        public double ThongKeDoanhThu(DateTime startDate, DateTime endDate, int idPhim)
        {
            var query = db.Ves;
            double doanhThu = 0;
            if (!startDate.Equals(DateTime.MinValue) || startDate != null)
                query = (System.Data.Entity.DbSet<eVe>)query.Where(x => x.ngayXuatVe.CompareTo(startDate) >= 0);
            if (!endDate.Equals(DateTime.MinValue) || endDate != null)
                query = (System.Data.Entity.DbSet<eVe>)query.Where(x => x.ngayXuatVe.CompareTo(endDate) <= 0);

            var listFillByDate = query.ToList();

            foreach (var item in listFillByDate)
            {
                doanhThu += item.giaVe;
            }

            if (idPhim != 0)
            {
                // Láy được những vé có suất chiếu có idphim
                var suatChieus = db.SuatChieus.Where(x => x.idPhim.Equals(idPhim)).ToList();

                foreach (var suatChieu in suatChieus)
                {
                    var check = db.Ves.FirstOrDefault(x => x.idSuatChieu.Equals(suatChieu.idSuatChieu));
                    if (!listFillByDate.Contains(check))
                        doanhThu += check.giaVe;
                }
            }
            return doanhThu;
        }
    }
}
