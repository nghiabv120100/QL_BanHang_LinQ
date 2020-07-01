using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang_LinQ.DTO
{
    public class BieuDo
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
        public float PhanTram { get; set; }
        public float PhanTramTongTien { get; set; }
    }
}
