using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ve
    {
        [Key]
        public int idVe { get; set; }
        public string gheNgoi { get; set; }
        public double giaVe { get; set; }
        public DateTime ngayXuatVe { get; set; }

        public int idNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        public int idSuatChieu { get; set; }
        public virtual SuatChieu SuatChieu { get; set; }

        public int idRapPhim { get; set; }
        public virtual RapPhim RapPhim { get; set; }
    }
}
