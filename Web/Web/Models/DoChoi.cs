using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Web.Models
{
    public class DoChoi
    {
        [Key]
        [Display(Name ="Mã Đồ Chơi")]
        public string MaDoChoi { get; set; }
        [Display(Name ="Tên Đồ Chơi")]
        public string TenDoChoi { get; set; }
    }
}
