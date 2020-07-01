using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang_LinQ.DTO
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongTien { get; set; }
    }
}
