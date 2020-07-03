using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eSuatChieu
    {
        [Key]
        public int idSuatChieu { get; set; }
        public string thoiGianChieu { get; set; }


        //public virtual ICollection<eVe> eVes { get; set; }

        public int idPhim { get; set; }
        //public virtual ePhim ePhim { get; set; }
    }
}
