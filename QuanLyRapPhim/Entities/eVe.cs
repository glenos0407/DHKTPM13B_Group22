using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eVe
    {
        [Key]
        public int idVe { get; set; }
        public string gheNgoi { get; set; }
        public double giaVe { get; set; }
        public DateTime ngayXuatVe { get; set; }

        public int idNhanVien { get; set; }
        //public virtual eNhanVien eNhanVien { get; set; }

        public int idSuatChieu { get; set; }
        //public virtual eSuatChieu eSuatChieu { get; set; }

        public int idRapPhim { get; set; }
        //public virtual eRapPhim eRapPhim { get; set; }
    }
}
