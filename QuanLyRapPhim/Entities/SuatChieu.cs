using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SuatChieu
    {
        [Key]
        public int idSuatChieu { get; set; }
        public string thoiGianChieu { get; set; }


        public virtual ICollection<Ve> Ves { get; set; }

        public int idPhim { get; set; }
        public Phim Phim { get; set; }
    }
}
