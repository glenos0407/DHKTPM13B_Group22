using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RapPhim
    {
        [Key]
        public int idRapPhim { get; set; }
        public string diaChi { get; set; }
        public string tenRnap { get; set; }
        public string hotLine { get; set; }
        public int soLuongChoNgoi { get; set; }

        public virtual ICollection<Ve> Ves { get; set; }
    }
}
