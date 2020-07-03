using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NhanVien
    {
        [Key]
        public int idNhanVien { get; set; }
        public string hoTen { get; set; }
        public string cmnd { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string soDienThoai { get; set; }
        public ChucVu chucVu { get; set; }

        public virtual ICollection<Ve> Ves { get; set; }
    }
}
