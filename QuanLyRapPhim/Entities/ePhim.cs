using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhim
    {
        [Key]
        public int idPhim { get; set; }
        public int luaTuoi { get; set; }
        public DateTime ngayCongChieu { get; set; }
        public DateTime ngayDongPhim { get; set; }
        public string ngonNgu { get; set; }
        public string noiDungPhim { get; set; }
        public string poster { get; set; }
        public string tenDaoDien { get; set; }
        public string tenPhim { get; set; }
        public string theLoai { get; set; }
        public int thoiLuong { get; set; }

        //public virtual ICollection<eSuatChieu> eSuatChieus { get; set; }
    }
}

/*
 *  SuatChieu:
 *  + SuatChieu ko có id
 *  
 *  Ve:
 *  + idVe: string
 *  + thoiGianInVe: int
 *  + gheNgoi: int
 *  
 *  RapPhim:
 *  + idRap: string
 *  
 */
