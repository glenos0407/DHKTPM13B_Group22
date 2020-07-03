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
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<RapPhim> RapPhims { get; set; }
        public DbSet<SuatChieu> SuatChieus { get; set; }
        public DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
