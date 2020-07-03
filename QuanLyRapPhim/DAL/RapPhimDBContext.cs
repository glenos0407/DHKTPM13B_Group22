using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RapPhimDBContext : DbContext
    {
        public RapPhimDBContext() : base("connectionString")
        { 

        }
        public DbSet<eNhanVien> NhanViens { get; set; }
        public DbSet<ePhim> Phims { get; set; }
        public DbSet<eRapPhim> RapPhims { get; set; }
        public DbSet<eSuatChieu> SuatChieus { get; set; }
        public DbSet<eVe> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
